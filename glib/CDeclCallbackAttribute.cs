// CDeclCallbackAttribute.cs
//
// Author:   Mike Kestner  <mkestner@ximian.com>
//
// Copyright (c) 2005 Novell, Inc.
//
// This program is free software; you can redistribute it and/or
// modify it under the terms of version 2 of the Lesser GNU General 
// Public License as published by the Free Software Foundation.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public
// License along with this program; if not, write to the
// Free Software Foundation, Inc., 59 Temple Place - Suite 330,
// Boston, MA 02111-1307, USA.


namespace GLib {

	using System;

	[Obsolete ("You must use the UnmanagedFunctionPointer attribute with value 'CallingConvention.Cdecl'. This attribute does not set the delegate to 'cdecl' correctly")]
	public sealed class CDeclCallbackAttribute : Attribute 
	{
	}
}

