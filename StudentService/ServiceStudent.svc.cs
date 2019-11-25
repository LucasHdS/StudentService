using System;
using System.Collections.Generic;

namespace StudentService
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Service1" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione Service1.svc ou Service1.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class ServiceStudent:IStudent
    {
        public void CreateStudent(Student student)
        {
            new Student()
            {
                name = student.name,
                cpf = student.cpf,
                courseID = student.courseID,
                genderID = student.genderID
            }.Save();
        }

        public void DeleteStudent(string id)
        {
            Student.Delete(Convert.ToInt32(id));
        }

        public List<Student> GetStudents()
        {
            return Student.List();
        }

        public void UpdateStudent(Student student)
        {
            Student.Update(student);
        }
    }
}
