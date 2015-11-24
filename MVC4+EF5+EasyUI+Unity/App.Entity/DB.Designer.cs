﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
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
namespace App.Entity
{
    #region 上下文
    
    /// <summary>
    /// 没有元数据文档可用。
    /// </summary>
    public partial class DBContainer : ObjectContext
    {
        #region 构造函数
    
        /// <summary>
        /// 请使用应用程序配置文件的“DBContainer”部分中的连接字符串初始化新 DBContainer 对象。
        /// </summary>
        public DBContainer() : base("name=DBContainer", "DBContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// 初始化新的 DBContainer 对象。
        /// </summary>
        public DBContainer(string connectionString) : base(connectionString, "DBContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// 初始化新的 DBContainer 对象。
        /// </summary>
        public DBContainer(EntityConnection connection) : base(connection, "DBContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region 分部方法
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet 属性
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        public ObjectSet<SysSample> SysSample
        {
            get
            {
                if ((_SysSample == null))
                {
                    _SysSample = base.CreateObjectSet<SysSample>("SysSample");
                }
                return _SysSample;
            }
        }
        private ObjectSet<SysSample> _SysSample;

        #endregion

        #region AddTo 方法
    
        /// <summary>
        /// 用于向 SysSample EntitySet 添加新对象的方法，已弃用。请考虑改用关联的 ObjectSet&lt;T&gt; 属性的 .Add 方法。
        /// </summary>
        public void AddToSysSample(SysSample sysSample)
        {
            base.AddObject("SysSample", sysSample);
        }

        #endregion

    }

    #endregion

    #region 实体
    
    /// <summary>
    /// 没有元数据文档可用。
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="DB", Name="SysSample")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class SysSample : EntityObject
    {
        #region 工厂方法
    
        /// <summary>
        /// 创建新的 SysSample 对象。
        /// </summary>
        /// <param name="id">Id 属性的初始值。</param>
        public static SysSample CreateSysSample(global::System.String id)
        {
            SysSample sysSample = new SysSample();
            sysSample.Id = id;
            return sysSample;
        }

        #endregion

        #region 基元属性
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.String _Id;
        partial void OnIdChanging(global::System.String value);
        partial void OnIdChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Age
        {
            get
            {
                return _Age;
            }
            set
            {
                OnAgeChanging(value);
                ReportPropertyChanging("Age");
                _Age = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Age");
                OnAgeChanged();
            }
        }
        private Nullable<global::System.Int32> _Age;
        partial void OnAgeChanging(Nullable<global::System.Int32> value);
        partial void OnAgeChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> Bir
        {
            get
            {
                return _Bir;
            }
            set
            {
                OnBirChanging(value);
                ReportPropertyChanging("Bir");
                _Bir = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Bir");
                OnBirChanged();
            }
        }
        private Nullable<global::System.DateTime> _Bir;
        partial void OnBirChanging(Nullable<global::System.DateTime> value);
        partial void OnBirChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Photo
        {
            get
            {
                return _Photo;
            }
            set
            {
                OnPhotoChanging(value);
                ReportPropertyChanging("Photo");
                _Photo = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Photo");
                OnPhotoChanged();
            }
        }
        private global::System.String _Photo;
        partial void OnPhotoChanging(global::System.String value);
        partial void OnPhotoChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Note
        {
            get
            {
                return _Note;
            }
            set
            {
                OnNoteChanging(value);
                ReportPropertyChanging("Note");
                _Note = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Note");
                OnNoteChanged();
            }
        }
        private global::System.String _Note;
        partial void OnNoteChanging(global::System.String value);
        partial void OnNoteChanged();
    
        /// <summary>
        /// 没有元数据文档可用。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> CreateTime
        {
            get
            {
                return _CreateTime;
            }
            set
            {
                OnCreateTimeChanging(value);
                ReportPropertyChanging("CreateTime");
                _CreateTime = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CreateTime");
                OnCreateTimeChanged();
            }
        }
        private Nullable<global::System.DateTime> _CreateTime;
        partial void OnCreateTimeChanging(Nullable<global::System.DateTime> value);
        partial void OnCreateTimeChanged();

        #endregion

    
    }

    #endregion

    
}
