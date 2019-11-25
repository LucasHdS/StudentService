using System;
using System.Collections.Generic;

namespace StudentService
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Service1" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione Service1.svc ou Service1.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class Service1:IStudent
    {
        public void CreateStudent(string name,int cpf,int tel, int courseID, int genderID)
        {
            new Student()
            {
                name = name,
                cpf = cpf,
                courseID = courseID,
                genderID = genderID
            }.Save();
        }

        public void DeleteStudent()
        {
            throw new NotImplementedException();
        }

        public List<Student> GetStudents()
        {
            return Student.List();
        }

        public void UpdateStudent()
        {
            throw new NotImplementedException();
        }
    }
}
