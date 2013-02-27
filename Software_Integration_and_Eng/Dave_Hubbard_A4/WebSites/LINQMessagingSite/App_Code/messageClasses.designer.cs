﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.261
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Database")]
public partial class messageClassesDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertmessageServer(messageServer instance);
  partial void UpdatemessageServer(messageServer instance);
  partial void DeletemessageServer(messageServer instance);
  #endregion
	
	public messageClassesDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public messageClassesDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public messageClassesDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public messageClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public messageClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<messageServer> messageServers
	{
		get
		{
			return this.GetTable<messageServer>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.messageServer")]
public partial class messageServer : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private string _senderID;
	
	private string _receiverID;
	
	private string _timestamp;
	
	private string _msg;
	
	private int _msgID;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnsenderIDChanging(string value);
    partial void OnsenderIDChanged();
    partial void OnreceiverIDChanging(string value);
    partial void OnreceiverIDChanged();
    partial void OntimestampChanging(string value);
    partial void OntimestampChanged();
    partial void OnmsgChanging(string value);
    partial void OnmsgChanged();
    partial void OnmsgIDChanging(int value);
    partial void OnmsgIDChanged();
    #endregion
	
	public messageServer()
	{
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_senderID", DbType="Text", UpdateCheck=UpdateCheck.Never)]
	public string senderID
	{
		get
		{
			return this._senderID;
		}
		set
		{
			if ((this._senderID != value))
			{
				this.OnsenderIDChanging(value);
				this.SendPropertyChanging();
				this._senderID = value;
				this.SendPropertyChanged("senderID");
				this.OnsenderIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_receiverID", DbType="NChar(50)")]
	public string receiverID
	{
		get
		{
			return this._receiverID;
		}
		set
		{
			if ((this._receiverID != value))
			{
				this.OnreceiverIDChanging(value);
				this.SendPropertyChanging();
				this._receiverID = value;
				this.SendPropertyChanged("receiverID");
				this.OnreceiverIDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_timestamp", DbType="Text", UpdateCheck=UpdateCheck.Never)]
	public string timestamp
	{
		get
		{
			return this._timestamp;
		}
		set
		{
			if ((this._timestamp != value))
			{
				this.OntimestampChanging(value);
				this.SendPropertyChanging();
				this._timestamp = value;
				this.SendPropertyChanged("timestamp");
				this.OntimestampChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_msg", DbType="Text", UpdateCheck=UpdateCheck.Never)]
	public string msg
	{
		get
		{
			return this._msg;
		}
		set
		{
			if ((this._msg != value))
			{
				this.OnmsgChanging(value);
				this.SendPropertyChanging();
				this._msg = value;
				this.SendPropertyChanged("msg");
				this.OnmsgChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_msgID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int msgID
	{
		get
		{
			return this._msgID;
		}
		set
		{
			if ((this._msgID != value))
			{
				this.OnmsgIDChanging(value);
				this.SendPropertyChanging();
				this._msgID = value;
				this.SendPropertyChanged("msgID");
				this.OnmsgIDChanged();
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
#pragma warning restore 1591
