﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.0.1.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(sender As Global.System.Object, e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("POS-58")>  _
        Public Property PrinterName() As String
            Get
                Return CType(Me("PrinterName"),String)
            End Get
            Set
                Me("PrinterName") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("C:\Users\vasilymakrov\Desktop\msiLogo_2017.bmp")>  _
        Public Property LogoPath() As String
            Get
                Return CType(Me("LogoPath"),String)
            End Get
            Set
                Me("LogoPath") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property PrinterInUse() As Boolean
            Get
                Return CType(Me("PrinterInUse"),Boolean)
            End Get
            Set
                Me("PrinterInUse") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Times New Roman")>  _
        Public Property PrinterFont() As String
            Get
                Return CType(Me("PrinterFont"),String)
            End Get
            Set
                Me("PrinterFont") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("<?xml version=""1.0"" encoding=""utf-16""?>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<ArrayOfString xmlns:xsi=""http://www.w3."& _ 
            "org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <s"& _ 
            "tring>7</string>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <string>18</string>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <string>28</string>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <string>40</st"& _ 
            "ring>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <string>7</string>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <string>18</string>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <string>28</string>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"  <st"& _ 
            "ring>40</string>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"</ArrayOfString>")>  _
        Public Property PrinterCalibrate() As Global.System.Collections.Specialized.StringCollection
            Get
                Return CType(Me("PrinterCalibrate"),Global.System.Collections.Specialized.StringCollection)
            End Get
            Set
                Me("PrinterCalibrate") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property OmitCalibration() As Boolean
            Get
                Return CType(Me("OmitCalibration"),Boolean)
            End Get
            Set
                Me("OmitCalibration") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("RaffleRaffle")>  _
        Public Property SlipTitle() As String
            Get
                Return CType(Me("SlipTitle"),String)
            End Get
            Set
                Me("SlipTitle") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property PrintDateAndTime() As Boolean
            Get
                Return CType(Me("PrintDateAndTime"),Boolean)
            End Get
            Set
                Me("PrintDateAndTime") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Сохраняйте купон до конца мероприятия! Он пригодится вам во время розыгрыша призо"& _ 
            "в.")>  _
        Public Property SlipFooter() As String
            Get
                Return CType(Me("SlipFooter"),String)
            End Get
            Set
                Me("SlipFooter") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property PrintRaffle() As Boolean
            Get
                Return CType(Me("PrintRaffle"),Boolean)
            End Get
            Set
                Me("PrintRaffle") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("ОПУСТИ МЕНЯ В БАРАБАН")>  _
        Public Property RaffleComment() As String
            Get
                Return CType(Me("RaffleComment"),String)
            End Get
            Set
                Me("RaffleComment") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.SquidQueue.My.MySettings
            Get
                Return Global.SquidQueue.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
