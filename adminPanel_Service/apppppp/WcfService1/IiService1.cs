using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WcfService1.Model;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IiService1" in both code and config file together.
    [ServiceContract]
    public interface IiService1
    {
        [OperationContract]
        List<Books> kitapGetir(string deGet);

        [OperationContract]
        Books kitapDetay(int ID);

        [OperationContract]
        int kitapGuncelle(Books book);

        [OperationContract]
        int kitapEkle(Books book);

        [OperationContract]
        int kitapSil(Books book);

        [OperationContract]
        List<Customers> musteriGetir(string deGet);

        [OperationContract]
        Customers musteriDetay(int id);

        [OperationContract]
        List<Orders> talepGetir(string deGet);

    }
}
