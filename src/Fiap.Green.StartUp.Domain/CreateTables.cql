===== PESSOA =====

CREATE TABLE PESSOA (
  IDPESSOA    NUMBER        PRIMARY KEY,
  NOMEPESSOA VARCHAR2(250)  NOT NULL,
  RG VARCHAR2(20)  NOT NULL,
  CPF VARCHAR2(12)  NOT NULL,
  DATANASCIMENTO VARCHAR2(20)  NOT NULL,
  UF VARCHAR2(10)  NOT NULL,
  CIDADE VARCHAR2(30)  NOT NULL,
  ENDERECO VARCHAR2(50)  NOT NULL,
  CEP VARCHAR2(10)  NOT NULL
  
);

CREATE SEQUENCE PESSOA_IDPESSOA_SEQ; 

CREATE OR REPLACE TRIGGER PESSOA_IDPESSOA_SEQ BEFORE INSERT ON PESSOA FOR EACH ROW 
BEGIN
SELECT PESSOA_IDPESSOA_SEQ.NEXTVAL
INTO :new.IDPESSOA
FROM dual;
END;

INSERT INTO PESSOA VALUES (PESSOA_IDPESSOA_SEQ.nextval,'Danilo Domingues','493202766','34519323851','02/12/1993','SP','Sao Paulo','Jose Inocencio da Costa','08151160');

===== USUARIO ====



CREATE TABLE USUARIO (
  IDUSUARIO    NUMBER        PRIMARY KEY,
  USERNAME VARCHAR2(250)  NOT NULL,
  SENHA VARCHAR2(20)  NOT NULL,
  EMAIL VARCHAR2(12)  NOT NULL,
  DATANASCIMENTO VARCHAR2(20)  NOT NULL,
  ATIVO VARCHAR2(10)  NOT NULL,
  EMAILSECUNDARIO VARCHAR2(30),
  IDPESSOA NUMBER,
  
);

CREATE SEQUENCE USUARIO_SEQ; 

CREATE OR REPLACE TRIGGER USUARIO_SEQ BEFORE INSERT ON USUARIO FOR EACH ROW 
BEGIN
SELECT USUARIO_SEQ.NEXTVAL
INTO :new.IDUSUARIO
FROM dual;
END;

ALTER TABLE USUARIO
ADD CONSTRAINT PESSOA_ID_PESSOA_FK 
  FOREIGN KEY (IDPESSOA)
  REFERENCES PESSOA(IDPESSOA);




using System.Runtime.CompilerServices;
using Fiap.Green.StartUp.Domain.Entities;
using FluentValidator;

namespace Fiap.Green.StartUp.Domain.ValueObjects
{
    public class RegisterPersonValidation : Notifiable
    {
        private readonly PessoaEntity pessoa;
        public RegisterPersonValidation(PessoaEntity pessoa)
        {
            this.pessoa = pessoa;

            
        }
        //public PessoaEntity PessoaContract { get; set; }

        public PessoaEntity ContractResult()
        {

            new ValidationContract<PessoaEntity>(this.pessoa)
                .IsNotNull(this.pessoa.NomePessoa, "username não informado!");
            return this.pessoa;
        }


    }
}