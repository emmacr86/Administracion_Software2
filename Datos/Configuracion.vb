﻿Public Class Configuracion
    Shared dbConexion As String = "Data Source=(local);Initial Catalog=pfinal;Integrated Security=True"
    Public Shared ReadOnly Property dbString() As String
        Get
            Return dbConexion
        End Get
    End Property
End Class
