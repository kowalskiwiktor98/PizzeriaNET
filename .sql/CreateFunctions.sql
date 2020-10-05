create function insertorder(email text, comment text, date timestamp without time zone) returns integer
    language plpgsql
as
$$
declare
    oID int;
begin
    WITH temp AS (INSERT INTO "Order" ("Email", "Comment", "Date") VALUES (Email, Comment, Date) RETURNING id as newID)
    SELECT newID
    FROM temp
    INTO oID;
    return oID;
end;
$$;

alter function insertorder(text, text, timestamp) owner to postgres;

create function selectitems()
    returns TABLE
            (
                name     character varying,
                category character varying,
                price    double precision
            )
    language plpgsql
as
$$
begin
    return query SELECT "Item"."Name", "Item"."Category", "Item"."Price" FROM "Item";
end;
$$;

alter function selectitems() owner to postgres;

create function insertorderitem(name character varying, quantity integer, orderid integer) returns void
    language plpgsql
as
$$
declare
    _ItemID int;
    _Price  double precision;
begin
    SELECT "Price" INTO _Price FROM "Item" WHERE "Name" = Name;
    SELECT "id" INTO _ItemID FROM "Item" WHERE "Name" = Name;
    INSERT INTO "OrderedItem"("OrderID", "ItemID", "Quantity", "Price") VALUES (OrderID, _ItemID, Quantity, _Price);
end;
$$;

alter function insertorderitem(varchar, integer, integer) owner to postgres;

create function selectorderhistory(_email text)
    returns TABLE
            (
                orderid  integer,
                name     character varying,
                quantity integer,
                price    real
            )
    language plpgsql
as
$$
begin
    return query SELECT O.id as OrderID, Item."Name", "Quantity", "OrderedItem"."Price"
                 FROM "OrderedItem"
                          JOIN "Order" O on "OrderedItem"."OrderID" = O.id
                          JOIN "Item" Item ON "OrderedItem"."ItemID" = Item.id
                 WHERE "Email" = _email;
end;
$$;

alter function selectorderhistory(text) owner to postgres;
