﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PayWithFriends.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="EZYD_20")]
	public partial class DbClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertQueriesLog(QueriesLog instance);
    partial void UpdateQueriesLog(QueriesLog instance);
    partial void DeleteQueriesLog(QueriesLog instance);
    partial void InsertTransactionsNew(TransactionsNew instance);
    partial void UpdateTransactionsNew(TransactionsNew instance);
    partial void DeleteTransactionsNew(TransactionsNew instance);
    partial void InsertTransactionsPending(TransactionsPending instance);
    partial void UpdateTransactionsPending(TransactionsPending instance);
    partial void DeleteTransactionsPending(TransactionsPending instance);
    partial void InsertExceptionsLog(ExceptionsLog instance);
    partial void UpdateExceptionsLog(ExceptionsLog instance);
    partial void DeleteExceptionsLog(ExceptionsLog instance);
    #endregion
		
		public DbClassesDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DbClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DbClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DbClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DbClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Friend> Friends
		{
			get
			{
				return this.GetTable<Friend>();
			}
		}
		
		public System.Data.Linq.Table<QueriesLog> QueriesLogs
		{
			get
			{
				return this.GetTable<QueriesLog>();
			}
		}
		
		public System.Data.Linq.Table<TransactionsNew> TransactionsNews
		{
			get
			{
				return this.GetTable<TransactionsNew>();
			}
		}
		
		public System.Data.Linq.Table<TransactionsPending> TransactionsPendings
		{
			get
			{
				return this.GetTable<TransactionsPending>();
			}
		}
		
		public System.Data.Linq.Table<ExceptionsLog> ExceptionsLogs
		{
			get
			{
				return this.GetTable<ExceptionsLog>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Friends")]
	public partial class Friend
	{
		
		private long _senderID;
		
		private long _receiverID;
		
		private bool _accepted;
		
		public Friend()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_senderID", DbType="BigInt NOT NULL")]
		public long senderID
		{
			get
			{
				return this._senderID;
			}
			set
			{
				if ((this._senderID != value))
				{
					this._senderID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_receiverID", DbType="BigInt NOT NULL")]
		public long receiverID
		{
			get
			{
				return this._receiverID;
			}
			set
			{
				if ((this._receiverID != value))
				{
					this._receiverID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_accepted", DbType="Bit NOT NULL")]
		public bool accepted
		{
			get
			{
				return this._accepted;
			}
			set
			{
				if ((this._accepted != value))
				{
					this._accepted = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.QueriesLog")]
	public partial class QueriesLog : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _query;
		
		private System.Nullable<System.DateTime> _datetime;
		
		private string _error;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnqueryChanging(string value);
    partial void OnqueryChanged();
    partial void OndatetimeChanging(System.Nullable<System.DateTime> value);
    partial void OndatetimeChanged();
    partial void OnerrorChanging(string value);
    partial void OnerrorChanged();
    #endregion
		
		public QueriesLog()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_query", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string query
		{
			get
			{
				return this._query;
			}
			set
			{
				if ((this._query != value))
				{
					this.OnqueryChanging(value);
					this.SendPropertyChanging();
					this._query = value;
					this.SendPropertyChanged("query");
					this.OnqueryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_datetime", DbType="DateTime")]
		public System.Nullable<System.DateTime> datetime
		{
			get
			{
				return this._datetime;
			}
			set
			{
				if ((this._datetime != value))
				{
					this.OndatetimeChanging(value);
					this.SendPropertyChanging();
					this._datetime = value;
					this.SendPropertyChanged("datetime");
					this.OndatetimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_error", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string error
		{
			get
			{
				return this._error;
			}
			set
			{
				if ((this._error != value))
				{
					this.OnerrorChanging(value);
					this.SendPropertyChanging();
					this._error = value;
					this.SendPropertyChanged("error");
					this.OnerrorChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TransactionsNew")]
	public partial class TransactionsNew : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _transactionID;
		
		private long _userID;
		
		private int _ballance;
		
		private System.Nullable<int> _expense;
		
		private System.Nullable<int> _income;
		
		private string _currency;
		
		private System.DateTime _datetime;
		
		private bool _accepted;
		
		private string _description;
		
		private byte _state;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OntransactionIDChanging(int value);
    partial void OntransactionIDChanged();
    partial void OnuserIDChanging(long value);
    partial void OnuserIDChanged();
    partial void OnballanceChanging(int value);
    partial void OnballanceChanged();
    partial void OnexpenseChanging(System.Nullable<int> value);
    partial void OnexpenseChanged();
    partial void OnincomeChanging(System.Nullable<int> value);
    partial void OnincomeChanged();
    partial void OncurrencyChanging(string value);
    partial void OncurrencyChanged();
    partial void OndatetimeChanging(System.DateTime value);
    partial void OndatetimeChanged();
    partial void OnacceptedChanging(bool value);
    partial void OnacceptedChanged();
    partial void OndescriptionChanging(string value);
    partial void OndescriptionChanged();
    partial void OnstateChanging(byte value);
    partial void OnstateChanged();
    #endregion
		
		public TransactionsNew()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_transactionID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int transactionID
		{
			get
			{
				return this._transactionID;
			}
			set
			{
				if ((this._transactionID != value))
				{
					this.OntransactionIDChanging(value);
					this.SendPropertyChanging();
					this._transactionID = value;
					this.SendPropertyChanged("transactionID");
					this.OntransactionIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userID", DbType="BigInt NOT NULL")]
		public long userID
		{
			get
			{
				return this._userID;
			}
			set
			{
				if ((this._userID != value))
				{
					this.OnuserIDChanging(value);
					this.SendPropertyChanging();
					this._userID = value;
					this.SendPropertyChanged("userID");
					this.OnuserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ballance", DbType="Int NOT NULL")]
		public int ballance
		{
			get
			{
				return this._ballance;
			}
			set
			{
				if ((this._ballance != value))
				{
					this.OnballanceChanging(value);
					this.SendPropertyChanging();
					this._ballance = value;
					this.SendPropertyChanged("ballance");
					this.OnballanceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_expense", DbType="Int")]
		public System.Nullable<int> expense
		{
			get
			{
				return this._expense;
			}
			set
			{
				if ((this._expense != value))
				{
					this.OnexpenseChanging(value);
					this.SendPropertyChanging();
					this._expense = value;
					this.SendPropertyChanged("expense");
					this.OnexpenseChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_income", DbType="Int")]
		public System.Nullable<int> income
		{
			get
			{
				return this._income;
			}
			set
			{
				if ((this._income != value))
				{
					this.OnincomeChanging(value);
					this.SendPropertyChanging();
					this._income = value;
					this.SendPropertyChanged("income");
					this.OnincomeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_currency", DbType="Char(3) NOT NULL", CanBeNull=false)]
		public string currency
		{
			get
			{
				return this._currency;
			}
			set
			{
				if ((this._currency != value))
				{
					this.OncurrencyChanging(value);
					this.SendPropertyChanging();
					this._currency = value;
					this.SendPropertyChanged("currency");
					this.OncurrencyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_datetime", DbType="DateTime NOT NULL")]
		public System.DateTime datetime
		{
			get
			{
				return this._datetime;
			}
			set
			{
				if ((this._datetime != value))
				{
					this.OndatetimeChanging(value);
					this.SendPropertyChanging();
					this._datetime = value;
					this.SendPropertyChanged("datetime");
					this.OndatetimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_accepted", DbType="Bit NOT NULL")]
		public bool accepted
		{
			get
			{
				return this._accepted;
			}
			set
			{
				if ((this._accepted != value))
				{
					this.OnacceptedChanging(value);
					this.SendPropertyChanging();
					this._accepted = value;
					this.SendPropertyChanged("accepted");
					this.OnacceptedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_description", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string description
		{
			get
			{
				return this._description;
			}
			set
			{
				if ((this._description != value))
				{
					this.OndescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("description");
					this.OndescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_state", DbType="TinyInt NOT NULL")]
		public byte state
		{
			get
			{
				return this._state;
			}
			set
			{
				if ((this._state != value))
				{
					this.OnstateChanging(value);
					this.SendPropertyChanging();
					this._state = value;
					this.SendPropertyChanged("state");
					this.OnstateChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TransactionsPending")]
	public partial class TransactionsPending : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _transactionID;
		
		private long _plusGuyID;
		
		private long _minusGuyID;
		
		private int _value;
		
		private string _currency;
		
		private System.DateTime _datetime;
		
		private string _description;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OntransactionIDChanging(int value);
    partial void OntransactionIDChanged();
    partial void OnplusGuyIDChanging(long value);
    partial void OnplusGuyIDChanged();
    partial void OnminusGuyIDChanging(long value);
    partial void OnminusGuyIDChanged();
    partial void OnvalueChanging(int value);
    partial void OnvalueChanged();
    partial void OncurrencyChanging(string value);
    partial void OncurrencyChanged();
    partial void OndatetimeChanging(System.DateTime value);
    partial void OndatetimeChanged();
    partial void OndescriptionChanging(string value);
    partial void OndescriptionChanged();
    #endregion
		
		public TransactionsPending()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_transactionID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int transactionID
		{
			get
			{
				return this._transactionID;
			}
			set
			{
				if ((this._transactionID != value))
				{
					this.OntransactionIDChanging(value);
					this.SendPropertyChanging();
					this._transactionID = value;
					this.SendPropertyChanged("transactionID");
					this.OntransactionIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_plusGuyID", DbType="BigInt NOT NULL")]
		public long plusGuyID
		{
			get
			{
				return this._plusGuyID;
			}
			set
			{
				if ((this._plusGuyID != value))
				{
					this.OnplusGuyIDChanging(value);
					this.SendPropertyChanging();
					this._plusGuyID = value;
					this.SendPropertyChanged("plusGuyID");
					this.OnplusGuyIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_minusGuyID", DbType="BigInt NOT NULL")]
		public long minusGuyID
		{
			get
			{
				return this._minusGuyID;
			}
			set
			{
				if ((this._minusGuyID != value))
				{
					this.OnminusGuyIDChanging(value);
					this.SendPropertyChanging();
					this._minusGuyID = value;
					this.SendPropertyChanged("minusGuyID");
					this.OnminusGuyIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_value", DbType="Int NOT NULL")]
		public int value
		{
			get
			{
				return this._value;
			}
			set
			{
				if ((this._value != value))
				{
					this.OnvalueChanging(value);
					this.SendPropertyChanging();
					this._value = value;
					this.SendPropertyChanged("value");
					this.OnvalueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_currency", DbType="Char(3) NOT NULL", CanBeNull=false)]
		public string currency
		{
			get
			{
				return this._currency;
			}
			set
			{
				if ((this._currency != value))
				{
					this.OncurrencyChanging(value);
					this.SendPropertyChanging();
					this._currency = value;
					this.SendPropertyChanged("currency");
					this.OncurrencyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_datetime", DbType="DateTime NOT NULL")]
		public System.DateTime datetime
		{
			get
			{
				return this._datetime;
			}
			set
			{
				if ((this._datetime != value))
				{
					this.OndatetimeChanging(value);
					this.SendPropertyChanging();
					this._datetime = value;
					this.SendPropertyChanged("datetime");
					this.OndatetimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_description", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string description
		{
			get
			{
				return this._description;
			}
			set
			{
				if ((this._description != value))
				{
					this.OndescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("description");
					this.OndescriptionChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ExceptionsLog")]
	public partial class ExceptionsLog : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _message;
		
		private string _stacktrace;
		
		private System.Nullable<System.DateTime> _datetime;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnmessageChanging(string value);
    partial void OnmessageChanged();
    partial void OnstacktraceChanging(string value);
    partial void OnstacktraceChanged();
    partial void OndatetimeChanging(System.Nullable<System.DateTime> value);
    partial void OndatetimeChanged();
    #endregion
		
		public ExceptionsLog()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_message", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string message
		{
			get
			{
				return this._message;
			}
			set
			{
				if ((this._message != value))
				{
					this.OnmessageChanging(value);
					this.SendPropertyChanging();
					this._message = value;
					this.SendPropertyChanged("message");
					this.OnmessageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_stacktrace", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string stacktrace
		{
			get
			{
				return this._stacktrace;
			}
			set
			{
				if ((this._stacktrace != value))
				{
					this.OnstacktraceChanging(value);
					this.SendPropertyChanging();
					this._stacktrace = value;
					this.SendPropertyChanged("stacktrace");
					this.OnstacktraceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_datetime", DbType="DateTime")]
		public System.Nullable<System.DateTime> datetime
		{
			get
			{
				return this._datetime;
			}
			set
			{
				if ((this._datetime != value))
				{
					this.OndatetimeChanging(value);
					this.SendPropertyChanging();
					this._datetime = value;
					this.SendPropertyChanged("datetime");
					this.OndatetimeChanged();
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