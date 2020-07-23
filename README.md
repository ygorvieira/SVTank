# SVTANK
API para Controle de Laudos de Inspeção de Equipamentos Industriais.

## Tecnologias utilizadas
.NET Core

Banco de Dados SQL Server

MicroORM Dapper

Visual Studio 2017

## Lista de endpoints

**Clientes**

**GET:** http://localhost:{nº da porta}/api/clientes/GetClientes/

**GET por ID:** http://localhost:{nº da porta}/api/clientes/GetCliente/ID/{idCliente}/

**POST:**  http://localhost:{nº da porta}/api/clientes/InsertCliente/

**PUT:**  http://localhost:{nº da porta}/api/clientes

**DELETE:** http://localhost:{nº da porta}/api/clientes/RemoveCliente/ID/{idCliente}/

**Tipos de Equipamentos**

**GET:** http://localhost:{nº da porta}/api/equipamentos/GetEquipamentos/

**GET por ID:** http://localhost:{nº da porta}/api/equipamentos/GetEquipamento/ID/{idEquipamento}/

**POST:**  http://localhost:{nº da porta}/api/equipamentos/InsertEquipamento/

**PUT:**  http://localhost:{nº da porta}/api/equipamentos/

**DELETE:** http://localhost:{nº da porta}/api/equipamentos/RemoveEquipamento/ID/{idEquipamento}/

**Laudos**

**GET:** http://localhost:{nº da porta}/api/laudos/GetLaudos/

**GET por ID:** http://localhost:{nº da porta}/api/laudos/GetLaudo/ID/{idLaudo}/

**GET por Data de Vencimento:** http://localhost:{nº da porta}/api/laudos/GetLaudosVencidos/DataVencimento/{data}/

**POST:**  http://localhost:{nº da porta}/api/laudos/InsertLaudo/

**PUT:**  http://localhost:{nº da porta}/api/laudos/

**DELETE:** http://localhost:{nº da porta}/api/laudos/RemoveLaudo/ID/{idLaudo}/