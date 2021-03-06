﻿'INSTANT VB TODO TASK: There is no equivalent to #pragma directives in VB.NET:
'#pragma warning disable 1591
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18051
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------


Imports Microsoft.VisualBasic
	Imports System.Data.Linq
	Imports System.Data.Linq.Mapping
	Imports System.Data
	Imports System.Collections.Generic
	Imports System.Reflection
	Imports System.Linq
	Imports System.Linq.Expressions
	Imports System.ComponentModel
	Imports System
Namespace Q515371.Models


	<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="Northwind")> _
	Partial Public Class NorthwindDataContext
		Inherits System.Data.Linq.DataContext

		Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()

	#Region "Extensibility Method Definitions"
	Partial Private Sub OnCreated()
	End Sub
	Partial Private Sub InsertEmployee(ByVal instance As Employee)
	End Sub
	Partial Private Sub UpdateEmployee(ByVal instance As Employee)
	End Sub
	Partial Private Sub DeleteEmployee(ByVal instance As Employee)
	End Sub
	#End Region

		Public Sub New()
			MyBase.New(Global.System.Configuration.ConfigurationManager.ConnectionStrings("NorthwindConnectionString").ConnectionString, mappingSource)
			OnCreated()
		End Sub

		Public Sub New(ByVal connection As String)
			MyBase.New(connection, mappingSource)
			OnCreated()
		End Sub

		Public Sub New(ByVal connection As System.Data.IDbConnection)
			MyBase.New(connection, mappingSource)
			OnCreated()
		End Sub

		Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
			MyBase.New(connection, mappingSource)
			OnCreated()
		End Sub

		Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
			MyBase.New(connection, mappingSource)
			OnCreated()
		End Sub

		Public ReadOnly Property Employees() As System.Data.Linq.Table(Of Employee)
			Get
				Return Me.GetTable(Of Employee)()
			End Get
		End Property
	End Class

	<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.Employees")> _
	Partial Public Class Employee
		Implements INotifyPropertyChanging, INotifyPropertyChanged

		Private Shared emptyChangingEventArgs As New PropertyChangingEventArgs(String.Empty)

		Private _EmployeeID As Integer

		Private _LastName As String

		Private _FirstName As String

		Private _Title As String

		Private _TitleOfCourtesy As String

		Private _BirthDate? As System.DateTime

		Private _HireDate? As System.DateTime

		Private _Address As String

		Private _City As String

		Private _Region As String

		Private _PostalCode As String

		Private _Country As String

		Private _HomePhone As String

		Private _Extension As String

		Private _Photo As System.Data.Linq.Binary

		Private _Notes As String

		Private _ReportsTo? As Integer

		Private _PhotoPath As String

		Private _Employees As EntitySet(Of Employee)

		Private _Employee1 As EntityRef(Of Employee)

	#Region "Extensibility Method Definitions"
	Partial Private Sub OnLoaded()
	End Sub
	Partial Private Sub OnValidate(ByVal action As System.Data.Linq.ChangeAction)
	End Sub
	Partial Private Sub OnCreated()
	End Sub
	Partial Private Sub OnEmployeeIDChanging(ByVal value As Integer)
	End Sub
	Partial Private Sub OnEmployeeIDChanged()
	End Sub
	Partial Private Sub OnLastNameChanging(ByVal value As String)
	End Sub
	Partial Private Sub OnLastNameChanged()
	End Sub
	Partial Private Sub OnFirstNameChanging(ByVal value As String)
	End Sub
	Partial Private Sub OnFirstNameChanged()
	End Sub
	Partial Private Sub OnTitleChanging(ByVal value As String)
	End Sub
	Partial Private Sub OnTitleChanged()
	End Sub
	Partial Private Sub OnTitleOfCourtesyChanging(ByVal value As String)
	End Sub
	Partial Private Sub OnTitleOfCourtesyChanged()
	End Sub
	Partial Private Sub OnBirthDateChanging(ByVal value? As System.DateTime)
	End Sub
	Partial Private Sub OnBirthDateChanged()
	End Sub
	Partial Private Sub OnHireDateChanging(ByVal value? As System.DateTime)
	End Sub
	Partial Private Sub OnHireDateChanged()
	End Sub
	Partial Private Sub OnAddressChanging(ByVal value As String)
	End Sub
	Partial Private Sub OnAddressChanged()
	End Sub
	Partial Private Sub OnCityChanging(ByVal value As String)
	End Sub
	Partial Private Sub OnCityChanged()
	End Sub
	Partial Private Sub OnRegionChanging(ByVal value As String)
	End Sub
	Partial Private Sub OnRegionChanged()
	End Sub
	Partial Private Sub OnPostalCodeChanging(ByVal value As String)
	End Sub
	Partial Private Sub OnPostalCodeChanged()
	End Sub
	Partial Private Sub OnCountryChanging(ByVal value As String)
	End Sub
	Partial Private Sub OnCountryChanged()
	End Sub
	Partial Private Sub OnHomePhoneChanging(ByVal value As String)
	End Sub
	Partial Private Sub OnHomePhoneChanged()
	End Sub
	Partial Private Sub OnExtensionChanging(ByVal value As String)
	End Sub
	Partial Private Sub OnExtensionChanged()
	End Sub
	Partial Private Sub OnPhotoChanging(ByVal value As System.Data.Linq.Binary)
	End Sub
	Partial Private Sub OnPhotoChanged()
	End Sub
	Partial Private Sub OnNotesChanging(ByVal value As String)
	End Sub
	Partial Private Sub OnNotesChanged()
	End Sub
	Partial Private Sub OnReportsToChanging(ByVal value? As Integer)
	End Sub
	Partial Private Sub OnReportsToChanged()
	End Sub
	Partial Private Sub OnPhotoPathChanging(ByVal value As String)
	End Sub
	Partial Private Sub OnPhotoPathChanged()
	End Sub
	#End Region

		Public Sub New()
			Me._Employees = New EntitySet(Of Employee)(New Action(Of Employee)(AddressOf Me.attach_Employees), New Action(Of Employee)(AddressOf Me.detach_Employees))
			Me._Employee1 = Nothing
			OnCreated()
		End Sub

		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_EmployeeID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=True, IsDbGenerated:=True)> _
		Public Property EmployeeID() As Integer
			Get
				Return Me._EmployeeID
			End Get
			Set(ByVal value As Integer)
				If (Me._EmployeeID <> value) Then
					Me.OnEmployeeIDChanging(value)
					Me.SendPropertyChanging()
					Me._EmployeeID = value
					Me.SendPropertyChanged("EmployeeID")
					Me.OnEmployeeIDChanged()
				End If
			End Set
		End Property

		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_LastName", DbType:="NVarChar(20) NOT NULL", CanBeNull:=False)> _
		Public Property LastName() As String
			Get
				Return Me._LastName
			End Get
			Set(ByVal value As String)
				If (Me._LastName <> value) Then
					Me.OnLastNameChanging(value)
					Me.SendPropertyChanging()
					Me._LastName = value
					Me.SendPropertyChanged("LastName")
					Me.OnLastNameChanged()
				End If
			End Set
		End Property

		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_FirstName", DbType:="NVarChar(10) NOT NULL", CanBeNull:=False)> _
		Public Property FirstName() As String
			Get
				Return Me._FirstName
			End Get
			Set(ByVal value As String)
				If (Me._FirstName <> value) Then
					Me.OnFirstNameChanging(value)
					Me.SendPropertyChanging()
					Me._FirstName = value
					Me.SendPropertyChanged("FirstName")
					Me.OnFirstNameChanged()
				End If
			End Set
		End Property

		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Title", DbType:="NVarChar(30)")> _
		Public Property Title() As String
			Get
				Return Me._Title
			End Get
			Set(ByVal value As String)
				If (Me._Title <> value) Then
					Me.OnTitleChanging(value)
					Me.SendPropertyChanging()
					Me._Title = value
					Me.SendPropertyChanged("Title")
					Me.OnTitleChanged()
				End If
			End Set
		End Property

		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_TitleOfCourtesy", DbType:="NVarChar(25)")> _
		Public Property TitleOfCourtesy() As String
			Get
				Return Me._TitleOfCourtesy
			End Get
			Set(ByVal value As String)
				If (Me._TitleOfCourtesy <> value) Then
					Me.OnTitleOfCourtesyChanging(value)
					Me.SendPropertyChanging()
					Me._TitleOfCourtesy = value
					Me.SendPropertyChanged("TitleOfCourtesy")
					Me.OnTitleOfCourtesyChanged()
				End If
			End Set
		End Property

		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_BirthDate", DbType:="DateTime")> _
		Public Property BirthDate() As System.DateTime?
			Get
				Return Me._BirthDate
			End Get
			Set(ByVal value? As System.DateTime)
				If (Not Me._BirthDate.Equals(value)) Then
					Me.OnBirthDateChanging(value)
					Me.SendPropertyChanging()
					Me._BirthDate = value
					Me.SendPropertyChanged("BirthDate")
					Me.OnBirthDateChanged()
				End If
			End Set
		End Property

		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_HireDate", DbType:="DateTime")> _
		Public Property HireDate() As System.DateTime?
			Get
				Return Me._HireDate
			End Get
			Set(ByVal value? As System.DateTime)
				If (Not Me._HireDate.Equals(value)) Then
					Me.OnHireDateChanging(value)
					Me.SendPropertyChanging()
					Me._HireDate = value
					Me.SendPropertyChanged("HireDate")
					Me.OnHireDateChanged()
				End If
			End Set
		End Property

		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Address", DbType:="NVarChar(60)")> _
		Public Property Address() As String
			Get
				Return Me._Address
			End Get
			Set(ByVal value As String)
				If (Me._Address <> value) Then
					Me.OnAddressChanging(value)
					Me.SendPropertyChanging()
					Me._Address = value
					Me.SendPropertyChanged("Address")
					Me.OnAddressChanged()
				End If
			End Set
		End Property

		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_City", DbType:="NVarChar(15)")> _
		Public Property City() As String
			Get
				Return Me._City
			End Get
			Set(ByVal value As String)
				If (Me._City <> value) Then
					Me.OnCityChanging(value)
					Me.SendPropertyChanging()
					Me._City = value
					Me.SendPropertyChanged("City")
					Me.OnCityChanged()
				End If
			End Set
		End Property

		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Region", DbType:="NVarChar(15)")> _
		Public Property Region() As String
			Get
				Return Me._Region
			End Get
			Set(ByVal value As String)
				If (Me._Region <> value) Then
					Me.OnRegionChanging(value)
					Me.SendPropertyChanging()
					Me._Region = value
					Me.SendPropertyChanged("Region")
					Me.OnRegionChanged()
				End If
			End Set
		End Property

		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_PostalCode", DbType:="NVarChar(10)")> _
		Public Property PostalCode() As String
			Get
				Return Me._PostalCode
			End Get
			Set(ByVal value As String)
				If (Me._PostalCode <> value) Then
					Me.OnPostalCodeChanging(value)
					Me.SendPropertyChanging()
					Me._PostalCode = value
					Me.SendPropertyChanged("PostalCode")
					Me.OnPostalCodeChanged()
				End If
			End Set
		End Property

		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Country", DbType:="NVarChar(15)")> _
		Public Property Country() As String
			Get
				Return Me._Country
			End Get
			Set(ByVal value As String)
				If (Me._Country <> value) Then
					Me.OnCountryChanging(value)
					Me.SendPropertyChanging()
					Me._Country = value
					Me.SendPropertyChanged("Country")
					Me.OnCountryChanged()
				End If
			End Set
		End Property

		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_HomePhone", DbType:="NVarChar(24)")> _
		Public Property HomePhone() As String
			Get
				Return Me._HomePhone
			End Get
			Set(ByVal value As String)
				If (Me._HomePhone <> value) Then
					Me.OnHomePhoneChanging(value)
					Me.SendPropertyChanging()
					Me._HomePhone = value
					Me.SendPropertyChanged("HomePhone")
					Me.OnHomePhoneChanged()
				End If
			End Set
		End Property

		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Extension", DbType:="NVarChar(4)")> _
		Public Property Extension() As String
			Get
				Return Me._Extension
			End Get
			Set(ByVal value As String)
				If (Me._Extension <> value) Then
					Me.OnExtensionChanging(value)
					Me.SendPropertyChanging()
					Me._Extension = value
					Me.SendPropertyChanged("Extension")
					Me.OnExtensionChanged()
				End If
			End Set
		End Property

		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Photo", DbType:="Image", UpdateCheck:=UpdateCheck.Never)> _
		Public Property Photo() As System.Data.Linq.Binary
			Get
				Return Me._Photo
			End Get
			Set(ByVal value As System.Data.Linq.Binary)
				If (Me._Photo IsNot value) Then
					Me.OnPhotoChanging(value)
					Me.SendPropertyChanging()
					Me._Photo = value
					Me.SendPropertyChanged("Photo")
					Me.OnPhotoChanged()
				End If
			End Set
		End Property

		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Notes", DbType:="NText", UpdateCheck:=UpdateCheck.Never)> _
		Public Property Notes() As String
			Get
				Return Me._Notes
			End Get
			Set(ByVal value As String)
				If (Me._Notes <> value) Then
					Me.OnNotesChanging(value)
					Me.SendPropertyChanging()
					Me._Notes = value
					Me.SendPropertyChanged("Notes")
					Me.OnNotesChanged()
				End If
			End Set
		End Property

		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ReportsTo", DbType:="Int")> _
		Public Property ReportsTo() As Integer?
			Get
				Return Me._ReportsTo
			End Get
			Set(ByVal value? As Integer)
				If (Not Me._ReportsTo.Equals(value)) Then
					If Me._Employee1.HasLoadedOrAssignedValue Then
						Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
					End If
					Me.OnReportsToChanging(value)
					Me.SendPropertyChanging()
					Me._ReportsTo = value
					Me.SendPropertyChanged("ReportsTo")
					Me.OnReportsToChanged()
				End If
			End Set
		End Property

		<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_PhotoPath", DbType:="NVarChar(255)")> _
		Public Property PhotoPath() As String
			Get
				Return Me._PhotoPath
			End Get
			Set(ByVal value As String)
				If (Me._PhotoPath <> value) Then
					Me.OnPhotoPathChanging(value)
					Me.SendPropertyChanging()
					Me._PhotoPath = value
					Me.SendPropertyChanged("PhotoPath")
					Me.OnPhotoPathChanged()
				End If
			End Set
		End Property

		<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Employee_Employee", Storage:="_Employees", ThisKey:="EmployeeID", OtherKey:="ReportsTo")> _
		Public Property Employees() As EntitySet(Of Employee)
			Get
				Return Me._Employees
			End Get
			Set(ByVal value As EntitySet(Of Employee))
				Me._Employees.Assign(value)
			End Set
		End Property

		<Global.System.Data.Linq.Mapping.AssociationAttribute(Name:="Employee_Employee", Storage:="_Employee1", ThisKey:="ReportsTo", OtherKey:="EmployeeID", IsForeignKey:=True)> _
		Public Property Employee1() As Employee
			Get
				Return Me._Employee1.Entity
			End Get
			Set(ByVal value As Employee)
				Dim previousValue As Employee = Me._Employee1.Entity
				If ((previousValue IsNot value) OrElse (Me._Employee1.HasLoadedOrAssignedValue = False)) Then
					Me.SendPropertyChanging()
					If (previousValue IsNot Nothing) Then
						Me._Employee1.Entity = Nothing
						previousValue.Employees.Remove(Me)
					End If
					Me._Employee1.Entity = value
					If (value IsNot Nothing) Then
						value.Employees.Add(Me)
						Me._ReportsTo = value.EmployeeID
					Else
						Me._ReportsTo = Nothing
					End If
					Me.SendPropertyChanged("Employee1")
				End If
			End Set
		End Property

		Public Event PropertyChanging As PropertyChangingEventHandler Implements INotifyPropertyChanging.PropertyChanging

		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

		Protected Overridable Sub SendPropertyChanging()
			If (Me.PropertyChangingEvent IsNot Nothing) Then
				RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
			End If
		End Sub

		Protected Overridable Sub SendPropertyChanged(ByVal propertyName As String)
			If (Me.PropertyChangedEvent IsNot Nothing) Then
				RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
			End If
		End Sub

		Private Sub attach_Employees(ByVal entity As Employee)
			Me.SendPropertyChanging()
			entity.Employee1 = Me
		End Sub

		Private Sub detach_Employees(ByVal entity As Employee)
			Me.SendPropertyChanging()
			entity.Employee1 = Nothing
		End Sub
	End Class
End Namespace
'INSTANT VB TODO TASK: There is no equivalent to #pragma directives in VB.NET:
'#pragma warning restore 1591
