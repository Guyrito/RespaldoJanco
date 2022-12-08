using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersistenciaBD;
using Controladores;

namespace PruebasUnitarias
{
    [TestClass]
    public class UpdateCliente
    {
        [TestMethod]
        public void TestMethodUpdateCliNombre()
        {
            ServiceCliente sc = new ServiceCliente();

            using (BD_NMAEntities db = new BD_NMAEntities())
            {
                db.crudUpdate("cliente", "Nombre_emp", "DATOPRUEBA", 1);
            }

            string resultado = sc.GetEntity(1).Nombre_emp;
            Assert.AreEqual(resultado, "DATOPRUEBA");

        }

        [TestMethod]
        public void TestMethodUpdateCliRut()
        {
            ServiceCliente sc = new ServiceCliente();
            using (BD_NMAEntities db = new BD_NMAEntities())
            {
                db.crudUpdate("cliente", "Rut_emp", "DATOPRUEBA", 1);
            }

            string resultado = sc.GetEntity(1).Rut_emp;
            Assert.AreEqual(resultado, "DATOPRUEBA");

        }

        [TestMethod]
        public void TestMethodUpdateCliDireccion()
        {
            ServiceCliente sc = new ServiceCliente();
            using (BD_NMAEntities db = new BD_NMAEntities())
            {
                db.crudUpdate("cliente", "Direccion_emp", "DATOPRUEBA", 1);
            }

            string resultado = sc.GetEntity(1).Direccion_emp;
            Assert.AreEqual(resultado, "DATOPRUEBA");

        }

        [TestMethod]
        public void TestMethodUpdateCliTelefono()
        {
            ServiceCliente sc = new ServiceCliente();
            using (BD_NMAEntities db = new BD_NMAEntities())
            {
                db.crudUpdate("cliente", "Fono_cliente", "DATOPRUEBA", 1);
            }

            string resultado = sc.GetEntity(1).Fono_cliente;
            Assert.AreEqual(resultado, "DATOPRUEBA");

        }

        [TestMethod]
        public void TestMethodUpdateGerNom()
        {
            ServiceGerente sg = new ServiceGerente();
            using (BD_NMAEntities db = new BD_NMAEntities())
            {
                db.crudUpdate("gerente", "Nombre_gerente", "DATOPRUEBA", 1);
            }

            string resultado = sg.GetEntity(1).Nombre_gerente;
            Assert.AreEqual(resultado, "DATOPRUEBA");

        }

        [TestMethod]
        public void TestMethodUpdateGerMail()
        {
            ServiceGerente sg = new ServiceGerente();
            using (BD_NMAEntities db = new BD_NMAEntities())
            {
                db.crudUpdate("gerente", "Mail_gerente", "DATOPRUEBA", 1);
            }

            string resultado = sg.GetEntity(1).Mail_gerente;
            Assert.AreEqual(resultado, "DATOPRUEBA");

        }

        [TestMethod]
        public void TestMethodUpdateProfNombre()
        {
            ServiceProfesional sp = new ServiceProfesional ();
            using (BD_NMAEntities db = new BD_NMAEntities())
            {
                db.crudUpdate("profesional", "Nombre_prof", "DATOPRUEBA", 1);
            }

            string resultado = sp.GetEntity(1).Nombre_prof;
            Assert.AreEqual(resultado, "DATOPRUEBA");

        }

        [TestMethod]
        public void TestMethodUpdateProfRut()
        {
            ServiceProfesional sp = new ServiceProfesional();
            using (BD_NMAEntities db = new BD_NMAEntities())
            {
                db.crudUpdate("profesional", "Rut_prof", "DATOPRUEBA", 1);
            }

            string resultado = sp.GetEntity(1).Rut_prof;
            Assert.AreEqual(resultado, "DATOPRUEBA");

        }

        [TestMethod]
        public void TestMethodUpdateProfApellido()
        {
            ServiceProfesional sp = new ServiceProfesional();
            using (BD_NMAEntities db = new BD_NMAEntities())
            {
                db.crudUpdate("profesional", "Apellido_prof", "DATOPRUEBA", 1);
            }

            string resultado = sp.GetEntity(1).Apellido_prof;
            Assert.AreEqual(resultado, "DATOPRUEBA");

        }

        [TestMethod]
        public void TestMethodUpdateProfMail()
        {
            ServiceProfesional sp = new ServiceProfesional();
            using (BD_NMAEntities db = new BD_NMAEntities())
            {
                db.crudUpdate("profesional", "Mail_prof", "DATOPRUEBA", 1);
            }

            string resultado = sp.GetEntity(1).Mail_prof;
            Assert.AreEqual(resultado, "DATOPRUEBA");

        }

        [TestMethod]
        public void TestMethodUpdateProfTelefono()
        {
            ServiceProfesional sp = new ServiceProfesional();
            using (BD_NMAEntities db = new BD_NMAEntities())
            {
                db.crudUpdate("profesional", "Telefono_prof", "DATOPRUEBA", 1);
            }

            string resultado = sp.GetEntity(1).Telefono;
            Assert.AreEqual(resultado, "DATOPRUEBA");

        }

        [TestMethod]
        public void TestMethodUpdateProfDireccion()
        {
            ServiceProfesional sp = new ServiceProfesional();
            using (BD_NMAEntities db = new BD_NMAEntities())
            {
                db.crudUpdate("profesional", "Direccion", "DATOPRUEBA", 1);
            }

            string resultado = sp.GetEntity(1).Direccion;
            Assert.AreEqual(resultado, "DATOPRUEBA");

        }
    }
}
