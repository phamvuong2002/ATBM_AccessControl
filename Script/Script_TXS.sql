CONN ADMIN_GROUP8/ADMIN_GROUP8;

CREATE OR REPLACE PROCEDURE usp_CreateUser(Usr varchar2, Pass varchar2  )
AS
 strSQL VARCHAR(2000);
begin
    
     strSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE';
     EXECUTE IMMEDIATE (strSQL);
    
     strSQL := 'CREATE USER '||Usr||' IDENTIFIED BY '||Pass;
     EXECUTE IMMEDIATE (strSQL);
     strSQL := 'GRANT CONNECT TO '||Usr;
     EXECUTE IMMEDIATE (strSQL);
     
     strSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT"=FALSE';
     EXECUTE IMMEDIATE (strSQL);
END;
/
--exec usp_CreateUser('LISA','lisa');
--/

CREATE OR REPLACE PROCEDURE usp_DeleteUser(Usr varchar2 )
AS
 strSQL VARCHAR(2000);
begin
    
     strSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE';
     EXECUTE IMMEDIATE (strSQL);
    
     strSQL := 'DROP USER '||Usr;
     EXECUTE IMMEDIATE (strSQL);

     
     strSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT"=FALSE';
     EXECUTE IMMEDIATE (strSQL);
END;
/
--exec usp_DeleteUser('ROSEBENTRE');
--/

CREATE OR REPLACE PROCEDURE usp_UpdatePasswordUser(Usr varchar2, newPass varchar2 )
AS
 strSQL VARCHAR(2000);
begin
     strSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE';
     EXECUTE IMMEDIATE (strSQL);
     strSQL := 'alter user '||Usr||' identified by '||newPass;
     EXECUTE IMMEDIATE (strSQL);
     strSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT"=FALSE';
     EXECUTE IMMEDIATE (strSQL);
END;

/
-------------L?i----------------
--exec usp_UpdatePasswordUser('TEMP','jisoo');
--select * from dba_users WHERE USERNAME  = 'TEMP';
--alter user JOHN identified by john;
--select * from all_users;


CREATE OR REPLACE PROCEDURE usp_CreateRole(Rolename varchar2, Pass varchar2)
AS
 strSQL VARCHAR(2000);
begin
    
     strSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE';
     EXECUTE IMMEDIATE (strSQL);
        
    if Pass is null then
    begin
        strSQL := 'CREATE ROLE '||Rolename;
        EXECUTE IMMEDIATE (strSQL);
    end;
    else
        begin
         strSQL := 'CREATE ROLE '||Rolename||' IDENTIFIED BY '||Pass;
         EXECUTE IMMEDIATE (strSQL);
         end;
    end if;
     strSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT"=FALSE';
     EXECUTE IMMEDIATE (strSQL);
END;

/
--exec usp_CreateRole('JENNIE');
--/
--select * from dba_roles;

CREATE OR REPLACE PROCEDURE usp_DeleteRole(Rolename varchar2 )
AS
 strSQL VARCHAR(2000);
begin
    
     strSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT"=TRUE';
     EXECUTE IMMEDIATE (strSQL);
    
     strSQL := 'DROP Role '||Rolename;
     EXECUTE IMMEDIATE (strSQL);

     
     strSQL := 'ALTER SESSION SET "_ORACLE_SCRIPT"=FALSE';
     EXECUTE IMMEDIATE (strSQL);
END;
/
--exec usp_DeleteRole('JENNIE');
--/

CREATE OR REPLACE PROCEDURE usp_UpdatePasswordRole(Rolename varchar2, newPass varchar2 )
AS
 strSQL VARCHAR(2000);
begin
     strSQL := 'alter role '||Rolename||' identified by '||newPass;
     EXECUTE IMMEDIATE (strSQL);
END;
/
--CREATE TABLE EMP_20127570(
--  EMPNO NUMBER(4),
--  ENAME VARCHAR2(9),
--  JOB VARCHAR2(9),
--  MGR NUMBER(4),
--  HIREDATE DATE,
--  SAL NUMBER(7,2),
--  COMM NUMBER(7,2),
--  DEPTNO NUMBER(2) NOT NULL,
--  
--  PRIMARY KEY(EMPNO)
--);
--grant select on EMP_20127570 to Lisa;
--grant select on EMP_20127570 to JISOO;
--select * from DBA_TAB_PRIVS where grantee = 'JISOO';
-------------L?i----------------

CREATE OR REPLACE PROCEDURE usp_FindPriviOfGrantee(granteeName varchar2)
AS
 Cursor_1 sys_refcursor;
begin
        OPEN Cursor_1 FOR SELECT * FROM DBA_TAB_PRIVS WHERE GRANTEE=granteeName;
        DBMS_SQL.RETURN_RESULT(Cursor_1);
END;
/
--exec usp_FindPriviOfGrantee('JENNIE');

CREATE OR REPLACE PROCEDURE usp_RevokeSelect(granteeName varchar2, tablename varchar2)
AS
 strSQL VARCHAR(2000);
begin
     strSQL := 'Revoke select on '||tablename|| ' from '||granteeName;
     EXECUTE IMMEDIATE (strSQL);
END;
/
--grant select on EMP_20127570 to JISOO;
--grant INSERT on EMP_20127570 to JISOO;
--grant UPDATE on EMP_20127570 to JISOO;
--grant DELETE on EMP_20127570 to JISOO;
--grant select on EMP_20127570 to JENNIE;
--grant select on EMP_20127570 to LISA;
--grant select on EMP_20127570 to ROSE;
--REVOKE select on EMP_20127570 from JISOO;
--REVOKE select on EMP_20127570 from jennie;

--grant dba to JISOO;
--/
--grant select on EMP_20127570 to LISA;
--exec usp_RevokeSelect('JISOO', 'EMP_20127570');
--SELECT * FROM DBA_TAB_PRIVS WHERE GRANTEE= 'LISA';
--/

--create or replace view BLACKPINK as 
--select * from EMP_20127570;
--
--select * from DBA_COL_PRIVS;
--select * from DBA_TAB_PRIVS;
--
--SELECT * FROM DBA_TAB_PRIVS where GRANTEE= 'JOE';
--grant SELECT on EMP_20127570 to JOE;
--grant UPDATE(EMPNO) on EMP_20127570 to JOE;
--REVOKE UPDATE(EMPNO) ON EMP_20127570 FROM JOE;
--
--SELECT * FROM LoadSysPrivs;