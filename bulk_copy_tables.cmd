@ECHO OFF
SET MYPATH=%~dp0
IF EXIST %MYPATH%bulk_copy_errors.log del /F %MYPATH%bulk_copy_errors.log
mysql_config_editor.exe remove --login-path=wb_migration_source 2>> "%MYPATH%bulk_copy_errors.log"
if %ERRORLEVEL% GEQ 1 (
    echo Script has failed. See the log file for details.
    exit /b 1
)
mysql_config_editor.exe set --login-path=wb_migration_source -h127.0.0.1 -P3306 -uroot -p 2>> "%MYPATH%bulk_copy_errors.log"
if %ERRORLEVEL% GEQ 1 (
    echo Script has failed. See the log file for details.
    exit /b 1
)
SET command=mysql.exe -h127.0.0.1 -P3306 -uroot -p -s -N information_schema -e "SELECT Variable_Value FROM GLOBAL_VARIABLES WHERE Variable_Name = 'datadir'" 2>> "%MYPATH%bulk_copy_errors.log"
FOR /F "tokens=* USEBACKQ" %%F IN (`%command%`) DO (
    SET DADADIR=%%F
)
if %ERRORLEVEL% GEQ 1 (
    echo Script has failed. See the log file for details.
    exit /b 1
)
pushd %DADADIR%
echo [0 %%] Creating directory dump_inventory_control
mkdir dump_inventory_control
pushd dump_inventory_control
copy NUL import_inventory_control.sql
echo SET SESSION UNIQUE_CHECKS=0; >> import_inventory_control.sql
echo SET SESSION FOREIGN_KEY_CHECKS=0; >> import_inventory_control.sql
echo use inventory_control_1; >> import_inventory_control.sql
echo [12 %%] Start dumping tables
mysqldump.exe --login-path=wb_migration_source -t --tab=. inventory_control purchase_of_products --fields-terminated-by=, 2>> "%MYPATH%bulk_copy_errors.log"
if %ERRORLEVEL% GEQ 1 (
    echo Script has failed. See the log file for details.
    exit /b 1
)
rename purchase_of_products.txt purchase_of_products.csv
del purchase_of_products.sql
echo LOAD DATA INFILE 'inventory_control_1_#####_import/purchase_of_products.csv' INTO TABLE purchase_of_products FIELDS TERMINATED BY ',' ENCLOSED BY ''; >> import_inventory_control.sql
echo [25 %%] Dumped table purchase_of_products
mysqldump.exe --login-path=wb_migration_source -t --tab=. inventory_control receipt_of_products --fields-terminated-by=, 2>> "%MYPATH%bulk_copy_errors.log"
if %ERRORLEVEL% GEQ 1 (
    echo Script has failed. See the log file for details.
    exit /b 1
)
rename receipt_of_products.txt receipt_of_products.csv
del receipt_of_products.sql
echo LOAD DATA INFILE 'inventory_control_1_#####_import/receipt_of_products.csv' INTO TABLE receipt_of_products FIELDS TERMINATED BY ',' ENCLOSED BY ''; >> import_inventory_control.sql
echo [37 %%] Dumped table receipt_of_products
mysqldump.exe --login-path=wb_migration_source -t --tab=. inventory_control products --fields-terminated-by=, 2>> "%MYPATH%bulk_copy_errors.log"
if %ERRORLEVEL% GEQ 1 (
    echo Script has failed. See the log file for details.
    exit /b 1
)
rename products.txt products.csv
del products.sql
echo LOAD DATA INFILE 'inventory_control_1_#####_import/products.csv' INTO TABLE products FIELDS TERMINATED BY ',' ENCLOSED BY ''; >> import_inventory_control.sql
echo [50 %%] Dumped table products
mysqldump.exe --login-path=wb_migration_source -t --tab=. inventory_control providers --fields-terminated-by=, 2>> "%MYPATH%bulk_copy_errors.log"
if %ERRORLEVEL% GEQ 1 (
    echo Script has failed. See the log file for details.
    exit /b 1
)
rename providers.txt providers.csv
del providers.sql
echo LOAD DATA INFILE 'inventory_control_1_#####_import/providers.csv' INTO TABLE providers FIELDS TERMINATED BY ',' ENCLOSED BY ''; >> import_inventory_control.sql
echo [62 %%] Dumped table providers
mysqldump.exe --login-path=wb_migration_source -t --tab=. inventory_control customers --fields-terminated-by=, 2>> "%MYPATH%bulk_copy_errors.log"
if %ERRORLEVEL% GEQ 1 (
    echo Script has failed. See the log file for details.
    exit /b 1
)
rename customers.txt customers.csv
del customers.sql
echo LOAD DATA INFILE 'inventory_control_1_#####_import/customers.csv' INTO TABLE customers FIELDS TERMINATED BY ',' ENCLOSED BY ''; >> import_inventory_control.sql
echo [75 %%] Dumped table customers
copy NUL import_inventory_control.cmd
(echo @ECHO OFF) >> import_inventory_control.cmd
(echo echo Started load data. Please wait.) >> import_inventory_control.cmd
(echo SET MYPATH=%%~dp0) >> import_inventory_control.cmd
(echo IF EXIST %%MYPATH%%import_errors.log del /F %%MYPATH%%import_errors.log) >> import_inventory_control.cmd
(echo SET command=mysql.exe -h127.0.0.1 -P3306 -uroot -p -s -N information_schema -e "SELECT Variable_Value FROM GLOBAL_VARIABLES WHERE Variable_Name = 'datadir'" 2^>^> %%MYPATH%%import_errors.log) >> import_inventory_control.cmd
(echo FOR /F "tokens=* USEBACKQ" %%%%F IN ^(^`%%command%%^`^) DO ^() >> import_inventory_control.cmd
(echo     SET DADADIR=%%%%F) >> import_inventory_control.cmd
(echo ^)) >> import_inventory_control.cmd
(echo if %%ERRORLEVEL%% GEQ 1 ^() >> import_inventory_control.cmd
(echo     echo Script has failed. See the log file for details.) >> import_inventory_control.cmd
(echo     exit /b 1) >> import_inventory_control.cmd
(echo ^)) >> import_inventory_control.cmd
(echo pushd %%DADADIR%%) >> import_inventory_control.cmd
(echo mkdir inventory_control_1_#####_import) >> import_inventory_control.cmd
(echo xcopy %%MYPATH%%*.csv inventory_control_1_#####_import\* 2^>^> %%MYPATH%%import_errors.log) >> import_inventory_control.cmd
(echo if %%ERRORLEVEL%% GEQ 1 ^() >> import_inventory_control.cmd
(echo     echo Script has failed. See the log file for details.) >> import_inventory_control.cmd
(echo     exit /b 1) >> import_inventory_control.cmd
(echo ^)) >> import_inventory_control.cmd
(echo xcopy %%MYPATH%%*.sql inventory_control_1_#####_import\* 2^>^> %%MYPATH%%import_errors.log) >> import_inventory_control.cmd
(echo if %%ERRORLEVEL%% GEQ 1 ^() >> import_inventory_control.cmd
(echo     echo Script has failed. See the log file for details.) >> import_inventory_control.cmd
(echo     exit /b 1) >> import_inventory_control.cmd
(echo ^)) >> import_inventory_control.cmd
(echo mysql.exe -h127.0.0.1 -P3306 -uroot -p ^< inventory_control_1_#####_import\import_inventory_control.sql 2^>^> %%MYPATH%%import_errors.log) >> import_inventory_control.cmd
(echo if %%ERRORLEVEL%% GEQ 1 ^() >> import_inventory_control.cmd
(echo     echo Script has failed. See the log file for details.) >> import_inventory_control.cmd
(echo     exit /b 1) >> import_inventory_control.cmd
(echo ^)) >> import_inventory_control.cmd
(echo rmdir inventory_control_1_#####_import /s /q) >> import_inventory_control.cmd
(echo echo Finished load data) >> import_inventory_control.cmd
(echo popd) >> import_inventory_control.cmd
(echo pause) >> import_inventory_control.cmd
echo [87 %%] Generated import script import_inventory_control.cmd
popd
set TEMPDIR=%DADADIR%dump_inventory_control
echo Set fso = CreateObject("Scripting.FileSystemObject") > _zipIt.vbs
echo InputFolder = fso.GetAbsolutePathName(WScript.Arguments.Item(0)) >> _zipIt.vbs
echo ZipFile = fso.GetAbsolutePathName(WScript.Arguments.Item(1)) >> _zipIt.vbs
echo CreateObject("Scripting.FileSystemObject").CreateTextFile(ZipFile, True).Write "PK" ^& Chr(5) ^& Chr(6) ^& String(18, vbNullChar) >> _zipIt.vbs
echo Set objShell = CreateObject("Shell.Application") >> _zipIt.vbs
echo Set source = objShell.NameSpace(InputFolder).Items >> _zipIt.vbs
echo objShell.NameSpace(ZipFile).CopyHere(source) >> _zipIt.vbs
echo Do Until objShell.NameSpace( ZipFile ).Items.Count ^= objShell.NameSpace( InputFolder ).Items.Count >> _zipIt.vbs
echo wScript.Sleep 200 >> _zipIt.vbs
echo Loop >> _zipIt.vbs
CScript  _zipIt.vbs  "%TEMPDIR%"  "%DADADIR%dump_inventory_control.zip" 2>> "%MYPATH%bulk_copy_errors.log"
if %ERRORLEVEL% GEQ 1 (
    echo Script has failed. See the log file for details.
    exit /b 1
)
echo [100 %%] Zipped all files to dump_inventory_control.zip file
xcopy dump_inventory_control.zip %MYPATH% 2>> "%MYPATH%bulk_copy_errors.log"
if %ERRORLEVEL% GEQ 1 (
    echo Script has failed. See the log file for details.
    exit /b 1
)
del dump_inventory_control.zip
del _zipIt.vbs
del /F /Q dump_inventory_control\*.*
rmdir dump_inventory_control
popd
echo Now you can copy %MYPATH%dump_inventory_control.zip file to the target server and run the import script.
pause
