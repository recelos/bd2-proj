INSERT INTO `user_type`
(`user_type_id`,
`user_type_name`)
VALUES
(1,'Użytkownik');

INSERT INTO `user_type`
(`user_type_id`,
`user_type_name`)
VALUES
(2,'Vip');

INSERT INTO `receipt_type`
(`receipt_type_id`,
`receipt_name`)
VALUES
(1, "Food");

INSERT INTO `receipt_type`
(`receipt_type_id`,
`receipt_name`)
VALUES
(2, "Gift");

INSERT INTO `bazy_projekt`.`countries`
(`id_country`,
`country_name`,
`currency`,
`shortcut`)
VALUES
(1,"Poland","PLN","PL");

INSERT INTO `users`
(`user_id`,
`user_name`,
`password`,
`first_name`,
`last_name`,
`user_type_id`,
`id_country`,
`creation_date`)
VALUES
(1,"craksys", "hasloo", "Kamil", "Kochan", 1, 1,now());


INSERT INTO `users`
(`user_id`,
`user_name`,
`password`,
`first_name`,
`last_name`,
`user_type_id`,
`id_country`,
`creation_date`)
VALUES
(2,"krystian", "hasloo", "Krystian", "Kowalski", 1, 1,now());


INSERT INTO `users`
(`user_id`,
`user_name`,
`password`,
`first_name`,
`last_name`,
`user_type_id`,
`id_country`,
`creation_date`)
VALUES
(3,"piotr", "hasloo", "Piotr", "Adamczyk", 1, 1,now());


INSERT INTO `users`
(`user_id`,
`user_name`,
`password`,
`first_name`,
`last_name`,
`user_type_id`,
`id_country`,
`creation_date`)
VALUES
(4,"marcin", "hasloo", "Marcin", "Górski", 1, 1,now());


INSERT INTO `users`
(`user_id`,
`user_name`,
`password`,
`first_name`,
`last_name`,
`user_type_id`,
`id_country`,
`creation_date`)
VALUES
(5,"wiktoria", "hasloo", "Wiktoria", "Nowak", 1, 1,now());


INSERT INTO `users`
(`user_id`,
`user_name`,
`password`,
`first_name`,
`last_name`,
`user_type_id`,
`id_country`,
`creation_date`)
VALUES
(6,"maciej", "hasloo", "Maciej", "Maciejewicz", 1, 1,now());

INSERT INTO `groups`
(`group_id`,
`name`,
`owner_id`)
VALUES
(1,"Grupa nr. 1", 1);

INSERT INTO `groups`
(`group_id`,
`name`,
`owner_id`)
VALUES
(2,"Grupa nr. 2", 5);

CALL `add_user_to_group`(1, 1);
CALL `add_user_to_group`(2, 1);
CALL `add_user_to_group`(3, 1);
CALL `add_user_to_group`(4, 1);
CALL `add_user_to_group`(6, 2);
CALL `add_user_to_group`(5, 2);

INSERT INTO `receipts`
(`receipt_id`,
`paying_user_id`,
`group_id`,
`amount`,
`name`,
`receipt_type_id`,
`date`)
VALUES
(1,1,1,100.10,"Za jedzenie",1,now());

INSERT INTO `receipts`
(`receipt_id`,
`paying_user_id`,
`group_id`,
`amount`,
`name`,
`receipt_type_id`,
`date`)
VALUES
(2,5,2,50.00,"Za prezent",2,now());

CALL `add_user_to_receipt`(2, 1, 50);
CALL `add_user_to_receipt`(3, 1, 50.10);
CALL `add_user_to_receipt`(6, 2, 50);


