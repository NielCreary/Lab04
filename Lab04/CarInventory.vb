Option Strict On
Public Class CarInventory


    Private Shared carCount As Integer                 ' static or shared private variable to hold the number of car
    Private carIdentificationNumber As Integer = 0     ' private variable to hold the car's identification number
    Private carMake As String = String.Empty         ' private variable to hold the customer's make
    Private carModel As String = String.Empty     ' private variable to hold the car's model
    Private yearOfRelease As String = String.Empty ' private variable to hold the car's year of release
    Private carPrice As Double = 0.0      ' private variable to hold the car's price
    Private carNew As Boolean = False              ' private variable to hold the car's status

    ''' <summary>
    ''' Constructor - Default - creates a new car object
    ''' </summary>
    Public Sub New()

        carCount += 1      ' increment the shared/static variable counter by 1
        carIdentificationNumber = carCount ' assign the car's id

    End Sub

    Public Sub New(make As String, model As String, modelYear As String, price As Double, newStatus As Boolean)

        ' call the other constructor 
        ' to set the car count and
        ' to set the car id
        Me.New()


        carMake = make          ' set the car's make
        carModel = model  ' set the car's model
        yearOfRelease = modelYear ' set the car's year of release
        carPrice = price    ' set the car's price
        carNew = newStatus        ' set the car's status

    End Sub


    ''' <summary>
    ''' Count ReadOnly Property - Gets the number of cars that have been instantiated/created
    ''' </summary>
    ''' <returns>Integer</returns>
    Public ReadOnly Property Count() As Integer
        Get
            Return carCount
        End Get
    End Property

    ''' <summary>
    ''' IdentificationNumber ReadOnly Property - Gets a specific car's identification number
    ''' </summary>
    ''' <returns>Integer</returns>
    Public ReadOnly Property IdentificationNumber() As Integer
        Get
            Return carIdentificationNumber
        End Get
    End Property

    ''' <summary>
    ''' CarNewStatus Property - >Gets and Sets the new status of a customer
    ''' </summary>
    ''' <returns>Boolean</returns>
    Public Property CarNewStatus() As Boolean
        Get
            Return carNew
        End Get
        Set(ByVal value As Boolean)
            carNew = value
        End Set
    End Property

    ''' <summary>
    ''' Title property - Gets and Sets the make of a car
    ''' </summary>
    ''' <returns>String</returns>
    Public Property Make() As String
        Get
            Return carMake
        End Get
        Set(ByVal value As String)
            carMake = value
        End Set
    End Property

    ''' <summary>
    ''' FirstName property - Gets and Sets the model of a car
    ''' </summary>
    ''' <returns>String</returns>
    Public Property Model() As String
        Get
            Return carModel
        End Get
        Set(ByVal value As String)
            carModel = value
        End Set
    End Property

    ''' <summary>
    ''' FirstName property - Gets and Sets the year of release of a car
    ''' </summary>
    ''' <returns>String</returns>
    Public Property CarYear() As String
        Get
            Return yearOfRelease
        End Get
        Set(ByVal value As String)
            carModel = value
        End Set
    End Property

    ''' <summary>
    ''' LastName property - Gets and Sets the price of a car
    ''' </summary>
    ''' <returns>String</returns>
    Public Property Price() As Double
        Get
            Return carPrice
        End Get
        Set(ByVal value As Double)
            carPrice = value
        End Set
    End Property



End Class
