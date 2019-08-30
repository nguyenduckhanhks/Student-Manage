﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SutdentManage
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="STUDENTMANAGE")]
	public partial class StudentManageDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertAclass(Aclass instance);
    partial void UpdateAclass(Aclass instance);
    partial void DeleteAclass(Aclass instance);
    partial void InsertAstudent(Astudent instance);
    partial void UpdateAstudent(Astudent instance);
    partial void DeleteAstudent(Astudent instance);
    #endregion
		
		public StudentManageDataContext() : 
				base(global::SutdentManage.Properties.Settings.Default.STUDENTMANAGEConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public StudentManageDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StudentManageDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StudentManageDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public StudentManageDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Aclass> Aclasses
		{
			get
			{
				return this.GetTable<Aclass>();
			}
		}
		
		public System.Data.Linq.Table<Astudent> Astudents
		{
			get
			{
				return this.GetTable<Astudent>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Aclass")]
	public partial class Aclass : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _id;
		
		private string _name;
		
		private int _numberOfStudents;
		
		private EntitySet<Astudent> _Astudents;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(string value);
    partial void OnidChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OnnumberOfStudentsChanging(int value);
    partial void OnnumberOfStudentsChanged();
    #endregion
		
		public Aclass()
		{
			this._Astudents = new EntitySet<Astudent>(new Action<Astudent>(this.attach_Astudents), new Action<Astudent>(this.detach_Astudents));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="NVarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_numberOfStudents", DbType="Int NOT NULL")]
		public int numberOfStudents
		{
			get
			{
				return this._numberOfStudents;
			}
			set
			{
				if ((this._numberOfStudents != value))
				{
					this.OnnumberOfStudentsChanging(value);
					this.SendPropertyChanging();
					this._numberOfStudents = value;
					this.SendPropertyChanged("numberOfStudents");
					this.OnnumberOfStudentsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Aclass_Astudent", Storage="_Astudents", ThisKey="id", OtherKey="idClass")]
		public EntitySet<Astudent> Astudents
		{
			get
			{
				return this._Astudents;
			}
			set
			{
				this._Astudents.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Astudents(Astudent entity)
		{
			this.SendPropertyChanging();
			entity.Aclass = this;
		}
		
		private void detach_Astudents(Astudent entity)
		{
			this.SendPropertyChanging();
			entity.Aclass = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Astudent")]
	public partial class Astudent : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _id;
		
		private string _idClass;
		
		private string _name;
		
		private System.DateTime _dateOfbirth;
		
		private string _telephone;
		
		private string _email;
		
		private int _male;
		
		private System.Nullable<double> _mathPoint;
		
		private System.Nullable<double> _physicalPoint;
		
		private System.Nullable<double> _chemicalPoint;
		
		private EntityRef<Aclass> _Aclass;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(string value);
    partial void OnidChanged();
    partial void OnidClassChanging(string value);
    partial void OnidClassChanged();
    partial void OnnameChanging(string value);
    partial void OnnameChanged();
    partial void OndateOfbirthChanging(System.DateTime value);
    partial void OndateOfbirthChanged();
    partial void OntelephoneChanging(string value);
    partial void OntelephoneChanged();
    partial void OnemailChanging(string value);
    partial void OnemailChanged();
    partial void OnmaleChanging(int value);
    partial void OnmaleChanged();
    partial void OnmathPointChanging(System.Nullable<double> value);
    partial void OnmathPointChanged();
    partial void OnphysicalPointChanging(System.Nullable<double> value);
    partial void OnphysicalPointChanged();
    partial void OnchemicalPointChanging(System.Nullable<double> value);
    partial void OnchemicalPointChanged();
    #endregion
		
		public Astudent()
		{
			this._Aclass = default(EntityRef<Aclass>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="NVarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idClass", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string idClass
		{
			get
			{
				return this._idClass;
			}
			set
			{
				if ((this._idClass != value))
				{
					if (this._Aclass.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnidClassChanging(value);
					this.SendPropertyChanging();
					this._idClass = value;
					this.SendPropertyChanged("idClass");
					this.OnidClassChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_name", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string name
		{
			get
			{
				return this._name;
			}
			set
			{
				if ((this._name != value))
				{
					this.OnnameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("name");
					this.OnnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dateOfbirth", DbType="Date NOT NULL")]
		public System.DateTime dateOfbirth
		{
			get
			{
				return this._dateOfbirth;
			}
			set
			{
				if ((this._dateOfbirth != value))
				{
					this.OndateOfbirthChanging(value);
					this.SendPropertyChanging();
					this._dateOfbirth = value;
					this.SendPropertyChanged("dateOfbirth");
					this.OndateOfbirthChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_telephone", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string telephone
		{
			get
			{
				return this._telephone;
			}
			set
			{
				if ((this._telephone != value))
				{
					this.OntelephoneChanging(value);
					this.SendPropertyChanging();
					this._telephone = value;
					this.SendPropertyChanged("telephone");
					this.OntelephoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_email", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string email
		{
			get
			{
				return this._email;
			}
			set
			{
				if ((this._email != value))
				{
					this.OnemailChanging(value);
					this.SendPropertyChanging();
					this._email = value;
					this.SendPropertyChanged("email");
					this.OnemailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_male", DbType="Int NOT NULL")]
		public int male
		{
			get
			{
				return this._male;
			}
			set
			{
				if ((this._male != value))
				{
					this.OnmaleChanging(value);
					this.SendPropertyChanging();
					this._male = value;
					this.SendPropertyChanged("male");
					this.OnmaleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mathPoint", DbType="Float")]
		public System.Nullable<double> mathPoint
		{
			get
			{
				return this._mathPoint;
			}
			set
			{
				if ((this._mathPoint != value))
				{
					this.OnmathPointChanging(value);
					this.SendPropertyChanging();
					this._mathPoint = value;
					this.SendPropertyChanged("mathPoint");
					this.OnmathPointChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_physicalPoint", DbType="Float")]
		public System.Nullable<double> physicalPoint
		{
			get
			{
				return this._physicalPoint;
			}
			set
			{
				if ((this._physicalPoint != value))
				{
					this.OnphysicalPointChanging(value);
					this.SendPropertyChanging();
					this._physicalPoint = value;
					this.SendPropertyChanged("physicalPoint");
					this.OnphysicalPointChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_chemicalPoint", DbType="Float")]
		public System.Nullable<double> chemicalPoint
		{
			get
			{
				return this._chemicalPoint;
			}
			set
			{
				if ((this._chemicalPoint != value))
				{
					this.OnchemicalPointChanging(value);
					this.SendPropertyChanging();
					this._chemicalPoint = value;
					this.SendPropertyChanged("chemicalPoint");
					this.OnchemicalPointChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Aclass_Astudent", Storage="_Aclass", ThisKey="idClass", OtherKey="id", IsForeignKey=true)]
		public Aclass Aclass
		{
			get
			{
				return this._Aclass.Entity;
			}
			set
			{
				Aclass previousValue = this._Aclass.Entity;
				if (((previousValue != value) 
							|| (this._Aclass.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Aclass.Entity = null;
						previousValue.Astudents.Remove(this);
					}
					this._Aclass.Entity = value;
					if ((value != null))
					{
						value.Astudents.Add(this);
						this._idClass = value.id;
					}
					else
					{
						this._idClass = default(string);
					}
					this.SendPropertyChanged("Aclass");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591