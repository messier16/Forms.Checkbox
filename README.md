# Checkbox Control Plugin for Xamarin

![Messier16.Forms.Checkbox](http://i.imgur.com/eDsT8PC.png)

A really simple implementation of a Checkbox control for Xamarin.Forms. Basically a stripped down version of XLabs' Checkbox mixed with Marxon13's M13Checkbox.

## I want it now  
Steps:  
#### 1 - Install  
From NuGet: [![NuGet version](https://badge.fury.io/nu/Messier16.Forms.Checkbox.svg)](https://badge.fury.io/nu/Messier16.Forms.Checkbox)

Remember to install the package in ALL your platform specific projects

#### 2 - SetUp 
Make sure to call `CheckboxRenderer.Init();` right after `Xamarin.Forms.Init();` in your projects. Look a tht `AppDelegate.cs` code snippet from the sample app:

```
    global::Xamarin.Forms.Forms.Init();
    CheckboxRenderer.Init();
```

### 3 - Usage

#### In code
##### Creating Checkboxes
```
var cb1 = new Checkbox() { WidthRequest = 55 };
var cb2 = new Checkbox() { WidthRequest = 45, IsEnabled = false };
var cb3 = new Checkbox() { WidthRequest = 35, Checked = true };
var cb4 = new Checkbox();
```
The checkbox is meant to be of an square shape, so to control the size of the checkbox please set only **WidthRequest**.

##### Assign events
```
cb1.CheckedChanged += 
    (sender, e) =>
    { 
        cb2.IsEnabled = e.IsChecked;
        cb3.Checked = !cb1.Checked;
    };
```  

#### XAML
// Working on it (in the documentation, of course)!
