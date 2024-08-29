CONN ADMIN_GROUP8/ADMIN_GROUP8;
--View de xem tat ca quyen he thong
CREATE OR REPLACE VIEW LoadSysPrivs 
AS
   SELECT DISTINCT(privilege) FROM DBA_SYS_PRIVS ORDER BY privilege;


/
---
CREATE OR REPLACE PROCEDURE Load_User_Role_SysPrivs 
    (username varchar2)
AS
    Cursor_1 sys_refcursor;
BEGIN
    IF username='ALL' then 
    OPEN Cursor_1 FOR SELECT * FROM DBA_SYS_PRIVS ;
    else
    OPEN Cursor_1 FOR SELECT * FROM DBA_SYS_PRIVS WHERE GRANTEE=username;
    end if;
     DBMS_SQL.RETURN_RESULT(Cursor_1);
END;
/
--EXECUTE Load_User_Role_SysPrivs ('ALL');
CREATE OR REPLACE PROCEDURE Load_User_Role_SysPrivs 
    (username varchar2)
AS
    Cursor_1 sys_refcursor;
BEGIN
    
    IF username='ALL' then
    OPEN Cursor_1 FOR SELECT * FROM DBA_SYS_PRIVS ;
    else
    OPEN Cursor_1 FOR SELECT * FROM DBA_SYS_PRIVS WHERE GRANTEE=username;
    end if;
     DBMS_SQL.RETURN_RESULT(Cursor_1);
END;
--SELECT * FROM DBA_SYS_PRIVS WHERE 



    
    
    










