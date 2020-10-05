create table "Order"
(
    id        serial                              not null
        constraint order_pk
            primary key,
    "Email"   text                                not null,
    "Comment" text,
    "Date"    timestamp default CURRENT_TIMESTAMP not null
);

alter table "Order"
    owner to postgres;

create unique index order_id_uindex
    on "Order" (id);

create table "Item"
(
    id         serial                     not null
        constraint item_pk
            primary key,
    "Name"     varchar                    not null,
    "Category" varchar                    not null,
    "Price"    double precision default 0 not null
);

alter table "Item"
    owner to postgres;

create unique index item_id_uindex
    on "Item" (id);

create table "OrderedItem"
(
    id         serial  not null
        constraint ordereditem_pk
            primary key,
    "OrderID"  integer not null
        constraint ordereditem_order_id_fk
            references "Order",
    "ItemID"   integer not null
        constraint ordereditem___fk_item
            references "Item",
    "Quantity" integer not null,
    "Price"    real    not null
);

alter table "OrderedItem"
    owner to postgres;

create unique index ordereditem_id_uindex
    on "OrderedItem" (id);
