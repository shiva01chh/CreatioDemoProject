﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OrderConstantsSchema

	/// <exclude/>
	public class OrderConstantsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OrderConstantsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OrderConstantsSchema(OrderConstantsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ed265f93-108e-4a1c-ac7b-79b19bae5ef1");
			Name = "OrderConstants";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d6ad04c1-fa0b-4adb-bfd8-17ec17775a03");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,149,209,110,155,48,20,134,175,137,148,119,176,186,155,77,194,9,198,198,198,106,87,41,1,82,245,106,145,186,23,48,96,34,52,32,145,1,77,81,149,119,159,33,164,131,142,68,73,59,75,49,1,255,231,248,51,62,254,169,203,180,216,128,151,125,89,201,252,126,58,169,123,183,51,111,155,101,50,170,210,109,81,206,158,100,33,85,26,105,201,116,82,136,92,150,59,17,73,240,83,42,37,202,109,82,105,109,145,164,155,90,137,70,62,251,161,98,169,214,34,250,37,54,114,58,121,157,78,140,93,29,102,105,4,202,74,11,34,16,101,162,44,129,142,209,247,69,85,234,241,70,51,42,106,83,53,131,173,194,104,187,249,124,14,30,202,58,207,133,218,63,118,79,142,66,144,22,96,167,182,27,37,117,104,147,167,46,103,127,67,230,131,152,225,108,74,138,120,91,100,123,240,84,167,241,49,217,115,177,238,82,189,180,153,158,99,240,29,20,242,119,43,249,122,231,185,140,216,20,19,24,44,220,37,36,212,231,112,185,96,8,34,238,242,37,119,16,99,182,127,247,237,254,42,236,88,137,228,211,188,190,78,82,141,162,162,4,139,24,219,20,202,36,137,33,17,17,134,2,75,27,114,135,73,22,203,4,83,151,92,139,26,53,59,173,242,118,163,63,141,236,245,146,141,146,219,60,17,148,74,172,201,41,135,36,145,33,20,142,72,160,140,80,44,145,237,8,138,174,32,95,11,85,165,34,211,83,239,68,26,127,8,247,45,197,90,103,24,32,50,159,112,135,251,24,90,75,119,5,137,133,61,184,192,196,129,120,181,244,2,110,83,11,225,160,69,156,78,64,175,189,3,125,63,228,137,34,146,153,140,71,130,230,227,81,151,232,79,217,6,224,238,98,105,173,92,108,65,110,53,5,108,249,12,186,214,2,67,182,34,60,88,49,203,11,152,245,1,240,109,190,203,100,245,223,200,79,233,6,232,26,54,112,105,16,64,155,17,95,163,115,23,234,51,167,11,58,88,250,158,94,147,79,86,222,237,232,199,10,4,187,109,153,182,174,119,121,5,134,113,129,221,79,91,227,212,202,135,134,216,212,198,84,61,118,19,172,187,252,221,138,198,165,175,195,201,155,246,58,114,204,77,128,192,193,60,171,29,59,95,38,176,47,133,252,235,122,38,192,103,2,6,135,194,4,228,140,236,109,15,77,224,156,147,116,5,106,2,10,14,167,119,123,184,109,3,193,151,83,3,253,203,236,163,133,216,251,0,173,197,62,151,69,247,214,91,175,56,126,142,70,236,166,125,52,228,56,66,24,227,166,243,206,117,58,179,209,93,55,131,177,145,213,219,127,67,201,170,86,69,255,36,48,27,97,236,74,109,139,9,130,196,177,57,228,52,148,48,198,9,70,200,65,174,139,236,147,65,26,198,225,120,61,220,4,127,43,123,223,40,175,91,132,176,19,196,34,22,234,15,18,13,33,97,145,62,206,82,56,48,116,136,19,50,34,108,154,208,51,139,104,251,166,211,191,67,83,46,253,246,7,193,169,49,223,222,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ed265f93-108e-4a1c-ac7b-79b19bae5ef1"));
		}

		#endregion

	}

	#endregion

}

