﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace Ej_LlenarDDL
{
    #region Contextos
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    public partial class EJEMPLOEntities : ObjectContext
    {
        #region Constructores
    
        /// <summary>
        /// Inicializa un nuevo objeto EJEMPLOEntities usando la cadena de conexión encontrada en la sección 'EJEMPLOEntities' del archivo de configuración de la aplicación.
        /// </summary>
        public EJEMPLOEntities() : base("name=EJEMPLOEntities", "EJEMPLOEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto EJEMPLOEntities.
        /// </summary>
        public EJEMPLOEntities(string connectionString) : base(connectionString, "EJEMPLOEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicializar un nuevo objeto EJEMPLOEntities.
        /// </summary>
        public EJEMPLOEntities(EntityConnection connection) : base(connection, "EJEMPLOEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Métodos parciales
    
        partial void OnContextCreated();
    
        #endregion
    
        #region Propiedades de ObjectSet
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        public ObjectSet<MailAlumnos> MAILS
        {
            get
            {
                if ((_MAILS == null))
                {
                    _MAILS = base.CreateObjectSet<MailAlumnos>("MAILS");
                }
                return _MAILS;
            }
        }
        private ObjectSet<MailAlumnos> _MAILS;

        #endregion

        #region Métodos AddTo
    
        /// <summary>
        /// Método desusado para agregar un nuevo objeto al EntitySet MAILS. Considere la posibilidad de usar el método .Add de la propiedad ObjectSet&lt;T&gt; asociada.
        /// </summary>
        public void AddToMAILS(MailAlumnos mailAlumnos)
        {
            base.AddObject("MAILS", mailAlumnos);
        }

        #endregion

    }

    #endregion

    #region Entidades
    
    /// <summary>
    /// No hay documentación de metadatos disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EJEMPLOModel", Name="MailAlumnos")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class MailAlumnos : EntityObject
    {
        #region Método de generador
    
        /// <summary>
        /// Crear un nuevo objeto MailAlumnos.
        /// </summary>
        /// <param name="idmail">Valor inicial de la propiedad idmail.</param>
        public static MailAlumnos CreateMailAlumnos(global::System.Int32 idmail)
        {
            MailAlumnos mailAlumnos = new MailAlumnos();
            mailAlumnos.idmail = idmail;
            return mailAlumnos;
        }

        #endregion

        #region Propiedades primitivas
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 idmail
        {
            get
            {
                return _idmail;
            }
            set
            {
                if (_idmail != value)
                {
                    OnidmailChanging(value);
                    ReportPropertyChanging("idmail");
                    _idmail = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("idmail");
                    OnidmailChanged();
                }
            }
        }
        private global::System.Int32 _idmail;
        partial void OnidmailChanging(global::System.Int32 value);
        partial void OnidmailChanged();
    
        /// <summary>
        /// No hay documentación de metadatos disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String mail
        {
            get
            {
                return _mail;
            }
            set
            {
                OnmailChanging(value);
                ReportPropertyChanging("mail");
                _mail = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("mail");
                OnmailChanged();
            }
        }
        private global::System.String _mail;
        partial void OnmailChanging(global::System.String value);
        partial void OnmailChanged();

        #endregion

    
    }

    #endregion

    
}
