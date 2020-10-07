create function insertorder(email text, comment text, date timestamp without time zone) returns integer
	language plpgsql
as $$
declare
        oID int;
begin
    WITH temp AS (INSERT INTO "Order"("Email", "Comment", "Date")  VALUES (Email, Comment, Date) RETURNING id as newID)
    SELECT newID FROM temp INTO oID;
    return oID;
end;
$$;

alter function insertorder(text, text, timestamp) owner to postgres;

create function selectorderhistory(_email text) returns TABLE(orderid integer, name character varying, quantity integer, price real)
	language plpgsql
as $$
begin
    return query SELECT O.id as OrderID, Item."Name", "Quantity", "OrderedItem"."Price" FROM "OrderedItem" JOIN "Order" O on "OrderedItem"."OrderID" = O.id JOIN "Item" Item ON "OrderedItem"."ItemID" = Item.id WHERE "Email" = _email;
end;
$$;

alter function selectorderhistory(text) owner to postgres;

create function selectitems() returns TABLE(id integer, name character varying, category character varying, price double precision)
	language plpgsql
as $$
begin
    return query SELECT "Item"."id", "Item"."Name", "Item"."Category", "Item"."Price" FROM "Item";
end;
$$;

alter function selectitems() owner to postgres;

create function insertorderitem(itemid integer, quantity integer, orderid integer) returns void
	language plpgsql
as $$
declare
        _Price double precision;
begin
    SELECT "Price" INTO _Price FROM "Item" WHERE "id" = ItemID;
    INSERT INTO "OrderedItem"("OrderID","ItemID","Quantity","Price") VALUES (OrderID, ItemID, Quantity, _Price);
end;
$$;

alter function insertorderitem(integer, integer, integer) owner to postgres;
