﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CalendarConstantsSchema

	/// <exclude/>
	public class CalendarConstantsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CalendarConstantsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CalendarConstantsSchema(CalendarConstantsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("be7f28d4-9023-4e82-8abd-f8718e729d3d");
			Name = "CalendarConstants";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d2179f89-6a33-4745-96ee-fd30f06a5c1f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,84,93,107,219,48,20,125,110,32,255,65,100,47,219,131,18,89,146,109,169,221,6,250,176,182,61,12,6,235,24,236,77,75,148,96,150,200,197,146,25,97,244,191,87,78,98,154,166,161,203,152,177,49,186,58,247,30,249,220,115,237,237,198,133,59,59,119,224,214,181,173,13,205,50,78,85,227,151,245,170,107,109,172,27,63,85,118,237,252,194,182,97,60,250,51,30,93,117,161,246,43,240,117,27,162,219,220,140,71,41,242,170,117,171,4,4,106,109,67,184,6,183,245,198,125,243,117,76,85,66,180,62,166,188,171,116,223,117,63,215,245,28,164,80,76,175,121,143,61,11,237,57,30,75,14,27,215,224,203,46,191,223,236,159,167,213,90,103,23,141,95,111,193,135,174,94,128,225,192,218,110,195,167,5,120,7,188,251,189,219,121,61,33,133,54,4,225,10,230,66,22,144,18,129,160,168,84,9,105,174,112,201,115,205,8,215,147,55,55,151,50,124,174,125,23,221,41,9,101,146,26,195,25,172,136,52,144,154,156,67,81,40,3,49,163,21,69,140,26,137,205,63,144,124,108,186,246,148,66,150,44,145,232,254,59,42,14,41,174,48,20,134,80,168,52,17,154,87,133,226,197,37,20,223,155,246,87,234,230,25,161,164,86,82,178,140,67,46,113,18,170,192,37,228,180,48,80,35,84,208,92,96,77,81,118,57,193,121,157,136,144,148,96,81,64,37,24,77,205,200,114,40,5,33,48,125,8,81,101,206,4,51,232,114,142,115,50,165,226,136,85,186,132,58,203,24,164,8,11,200,185,66,16,155,156,17,204,179,74,227,234,192,176,115,93,210,123,111,188,180,186,223,219,246,73,236,185,217,135,38,237,140,122,112,250,108,54,3,111,67,183,217,216,118,251,254,176,30,112,96,62,56,122,58,32,103,71,208,115,67,242,140,226,191,38,36,196,182,159,95,237,150,182,91,199,126,0,127,52,222,169,102,225,146,114,147,147,240,228,37,241,15,149,164,13,238,241,136,251,50,199,177,23,107,212,62,130,193,28,190,239,96,202,46,208,223,50,246,173,246,201,182,9,142,233,254,47,116,73,247,238,123,228,241,245,0,241,253,78,146,254,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("be7f28d4-9023-4e82-8abd-f8718e729d3d"));
		}

		#endregion

	}

	#endregion

}

