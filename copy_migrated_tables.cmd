REM Workbench Table Data copy script
REM Workbench Version: 6.3.9
REM 
REM Execute this to copy table data from a source RDBMS to MySQL.
REM Edit the options below to customize it. You will need to provide passwords, at least.
REM 
REM Source DB: Mysql@127.0.0.1:3306 (MySQL)
REM Target DB: Mysql@127.0.0.1:3306


@ECHO OFF
REM Source and target DB passwords
set arg_source_password=
set arg_target_password=

IF [%arg_source_password%] == [] (
    IF [%arg_target_password%] == [] (
        ECHO WARNING: Both source and target RDBMSes passwords are empty. You should edit this file to set them.
    )
)
set arg_worker_count=2
REM Uncomment the following options according to your needs

REM Whether target tables should be truncated before copy
REM set arg_truncate_target=--truncate-target
REM Enable debugging output
REM set arg_debug_output=--log-level=debug3


REM Creation of file with table definitions for copytable

set table_file="%TMP%\wb_tables_to_migrate.txt"
TYPE NUL > "%TMP%\wb_tables_to_migrate.txt"
ECHO `inventory_control`	`purchase_of_products`	`inventory_control_1`	`purchase_of_products`	`id_purchase`	`id_purchase`	`id_purchase`, `id_product_purchase`, `date`, `id_customer`, `quantity_purchase` >> "%TMP%\wb_tables_to_migrate.txt"
ECHO `inventory_control`	`receipt_of_products`	`inventory_control_1`	`receipt_of_products`	`id_receipt`	`id_receipt`	`id_receipt`, `id_product_receipt`, `date`, `id_provider`, `quantity_receipt` >> "%TMP%\wb_tables_to_migrate.txt"
ECHO `inventory_control`	`products`	`inventory_control_1`	`products`	`id_product`	`id_product`	`id_product`, `name_product`, `quantity_in_stock`, `price` >> "%TMP%\wb_tables_to_migrate.txt"
ECHO `inventory_control`	`providers`	`inventory_control_1`	`providers`	`id_provider`	`id_provider`	`id_provider`, `name_provider`, `address`, `phone_number`, `mail` >> "%TMP%\wb_tables_to_migrate.txt"
ECHO `inventory_control`	`customers`	`inventory_control_1`	`customers`	`id_customer`	`id_customer`	`id_customer`, `name_customer`, `address`, `phone_number`, `mail` >> "%TMP%\wb_tables_to_migrate.txt"


wbcopytables.exe ^
 --mysql-source="root@127.0.0.1:3306" ^
 --target="root@127.0.0.1:3306" ^
 --source-password="%arg_source_password%" ^
 --target-password="%arg_target_password%" ^
 --table-file="%table_file%" --thread-count=%arg_worker_count% ^
 %arg_truncate_target% ^
 %arg_debug_output%

REM Removes the file with the table definitions
DEL "%TMP%\wb_tables_to_migrate.txt"


