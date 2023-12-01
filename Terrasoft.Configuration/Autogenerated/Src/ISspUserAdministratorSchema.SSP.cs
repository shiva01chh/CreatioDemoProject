﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ISspUserAdministratorSchema

	/// <exclude/>
	public class ISspUserAdministratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ISspUserAdministratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ISspUserAdministratorSchema(ISspUserAdministratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("485de16c-639f-48e3-82c5-2ad4f26079fd");
			Name = "ISspUserAdministrator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7cc31540-fa76-4c79-9b86-a6eabd8e662c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,86,109,107,219,48,16,254,220,66,255,195,145,79,29,140,228,7,44,11,36,161,4,67,41,165,105,63,141,193,20,235,156,136,217,146,145,228,118,217,216,127,223,157,100,167,113,222,234,148,46,132,132,56,119,247,60,207,233,209,73,90,20,232,74,145,34,60,162,181,194,153,204,247,167,70,103,106,89,89,225,149,209,253,249,252,254,234,242,207,213,229,69,229,148,94,194,124,237,60,22,95,118,126,83,78,158,99,202,9,174,63,67,141,86,165,20,67,81,101,181,200,85,10,74,123,180,25,227,36,115,87,62,57,180,99,89,40,173,156,39,24,99,41,144,33,46,6,131,1,12,93,85,20,194,174,71,205,131,169,69,225,209,49,84,72,122,210,202,67,69,37,250,155,148,193,110,206,176,20,86,20,160,73,222,215,30,199,38,58,51,189,209,29,190,132,76,72,185,38,177,5,41,188,232,15,7,33,252,53,219,162,175,172,118,35,38,10,74,162,246,42,83,4,56,28,52,255,112,232,172,82,18,30,112,73,42,208,114,232,117,173,45,209,207,202,35,52,184,159,98,43,14,171,155,161,119,32,210,212,84,218,195,210,154,170,220,6,236,168,176,206,79,100,111,52,174,75,181,88,31,145,55,62,6,123,64,39,241,156,113,88,34,39,235,113,3,119,29,254,218,160,191,45,212,216,165,208,234,119,236,61,25,3,181,195,160,225,63,43,189,221,134,106,171,35,11,178,145,137,94,29,116,71,49,231,8,155,174,48,253,9,42,107,27,20,127,145,45,186,170,226,207,94,116,91,205,240,136,142,22,196,209,5,91,24,147,71,90,73,198,69,239,140,191,97,58,215,181,86,198,56,45,169,222,114,52,10,188,72,207,219,109,88,8,149,247,70,225,11,50,211,236,53,130,77,99,181,125,117,31,176,192,13,211,211,38,142,186,234,216,201,250,134,57,54,77,9,132,63,195,25,11,63,71,15,247,198,122,145,111,54,4,120,211,182,129,197,212,88,217,217,221,77,158,123,52,79,37,205,38,114,197,118,57,23,226,28,117,178,25,183,157,155,217,34,10,47,43,149,174,224,69,229,57,44,144,23,70,83,57,12,244,253,10,27,214,219,181,159,13,245,101,162,180,108,21,26,107,57,38,30,207,196,148,141,230,38,235,176,123,110,201,108,195,216,215,17,236,139,58,171,203,77,125,8,0,176,88,67,34,221,199,53,84,201,163,237,12,146,119,228,17,118,84,199,10,14,105,59,173,69,202,218,49,155,145,79,29,47,219,79,194,52,254,64,125,63,182,5,118,177,75,61,231,119,61,19,79,137,119,58,135,148,135,14,62,154,86,209,0,117,186,161,109,179,212,220,58,77,47,107,114,250,228,17,116,246,109,65,246,14,156,253,39,58,199,73,15,12,87,231,5,232,253,46,68,102,180,64,241,150,192,25,241,164,137,160,81,234,183,239,176,41,247,198,193,35,244,146,20,134,27,141,136,62,229,115,213,121,225,171,206,91,228,93,122,149,11,251,2,183,174,84,251,4,246,229,7,194,225,246,183,9,158,135,216,118,23,194,249,213,64,112,11,46,254,94,93,210,155,94,255,0,234,97,77,248,177,10,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("485de16c-639f-48e3-82c5-2ad4f26079fd"));
		}

		#endregion

	}

	#endregion

}

