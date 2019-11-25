using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace StudentService
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da interface "IService1" no arquivo de código e configuração ao mesmo tempo.
    [ServiceContract]
    public interface IStudent
    {

        [OperationContract]
        [WebGet(UriTemplate="getStudents")]
        List<Student> GetStudents();

        [OperationContract]
        [WebInvoke(UriTemplate="createStudent", RequestFormat = WebMessageFormat.Json)]
        void CreateStudent(string name, int cpf, int tel, int courseID, int genderID);

        [OperationContract]
        [WebInvoke(UriTemplate = "updateStudent", RequestFormat = WebMessageFormat.Json,Method = "UPDATE")]
        void UpdateStudent();

        [OperationContract]
        [WebInvoke(UriTemplate = "deleteStudent", RequestFormat = WebMessageFormat.Json,Method ="DELETE")]
        void DeleteStudent();
        // TODO: Adicione suas operações de serviço aqui
    }


    // Use um contrato de dados como ilustrado no exemplo abaixo para adicionar tipos compostos a operações de serviço.
    [DataContract]
    public class StudentType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public string name { get; set; }
        
    }
}
