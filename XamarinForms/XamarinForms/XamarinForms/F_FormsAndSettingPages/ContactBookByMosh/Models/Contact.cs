﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace XamarinForms.F_FormsAndSettingPages.ContactBookByMosh.Models
{
	public class Contact : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		public int Id { get; set; }

		private string _firstName;
		public string FirstName
		{
			get
			{
				return _firstName;
			}
			set
			{
				if (_firstName == value)
					return;

				_firstName = value;

				OnPropertyChanged();
			}
		}

		private string _lastName;
		public string LastName
		{
			get
			{
				return _lastName;
			}
			set
			{
				if (_lastName == value)
					return;

				_lastName = value;

				OnPropertyChanged();
			}
		}
		public string Phone { get; set; }
		public string Email { get; set; }
		public bool IsBlocked { get; set; }

		public string FullName
		{
			// Note the string interpolation syntax in C# 6. Read my blog post
			// for details: 
			// 
			// http://programmingwithmosh.com/csharp/csharp-6-features-that-help-you-write-cleaner-code/
			get { return $"{FirstName} {LastName}"; }
		}

		private void OnPropertyChanged([CallerMemberName]string propertyName = null)
		{
			//if (PropertyChanged !=null)
			//{
			//    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			//} same as,
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
