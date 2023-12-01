﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PostgresTypesCastOptionsAppListenerSchema

	/// <exclude/>
	public class PostgresTypesCastOptionsAppListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PostgresTypesCastOptionsAppListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PostgresTypesCastOptionsAppListenerSchema(PostgresTypesCastOptionsAppListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("af99ba40-7ed6-49ab-b28e-17f32134e193");
			Name = "PostgresTypesCastOptionsAppListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6e269b86-be8c-4c04-b44a-876ef2a93baf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,84,91,111,218,48,20,126,166,82,255,195,81,38,85,240,146,188,23,66,85,24,157,42,117,107,39,152,246,80,85,147,9,135,96,205,177,51,219,97,67,21,255,125,118,156,64,108,104,55,94,200,185,125,231,246,29,3,39,5,170,146,100,8,11,148,146,40,177,214,241,84,240,53,205,43,73,52,21,252,242,226,245,242,162,87,41,202,115,207,165,40,4,31,158,181,72,60,167,255,142,203,99,148,177,127,144,152,27,120,152,50,162,212,53,60,9,165,115,137,106,177,43,81,77,137,210,143,165,205,174,110,203,242,129,42,141,28,101,29,150,36,9,140,84,85,20,68,238,198,141,108,124,24,205,234,106,1,183,200,53,176,38,4,244,134,104,32,214,142,170,205,49,255,250,0,218,166,129,204,228,1,225,18,197,45,120,18,160,143,20,34,97,74,64,38,113,157,70,231,58,138,77,5,51,155,184,45,117,66,20,70,144,88,136,178,90,154,226,32,179,109,254,79,151,112,13,231,208,12,210,107,61,128,195,224,238,40,178,149,157,156,164,91,162,209,25,75,39,28,32,204,42,53,254,209,240,131,248,138,97,224,108,212,28,179,122,130,214,245,40,122,142,223,20,202,174,103,229,201,195,166,62,228,43,87,162,95,239,147,20,37,74,109,22,241,70,205,1,122,32,90,22,246,122,57,106,72,199,97,102,184,185,129,126,168,75,253,190,226,249,206,76,179,240,81,7,117,123,251,147,217,117,96,124,233,88,133,251,234,209,181,201,236,77,12,210,20,120,197,216,160,117,233,133,246,147,109,196,29,6,63,71,94,198,232,5,136,242,139,24,58,216,189,251,147,168,43,121,118,107,206,99,255,254,86,62,163,222,136,154,70,53,79,157,49,60,178,90,49,37,140,225,10,126,111,144,195,51,233,156,156,210,68,234,151,248,16,152,132,145,163,146,72,82,128,125,106,210,40,115,45,71,227,197,6,161,17,226,81,82,187,212,17,205,193,136,173,57,52,186,66,216,10,186,130,71,110,70,48,183,137,250,33,181,27,140,118,220,75,115,44,113,199,189,53,187,145,180,9,167,27,204,126,222,202,188,42,12,210,23,179,173,126,20,224,70,77,68,184,43,179,190,172,115,67,53,1,124,82,197,31,39,51,158,83,142,135,15,123,238,150,22,93,57,110,95,163,95,172,161,201,213,21,124,98,98,73,152,173,29,181,54,239,167,138,239,144,152,253,226,140,147,37,195,123,174,23,98,34,4,187,47,236,248,169,182,79,200,17,231,192,184,147,122,204,150,201,60,147,180,116,84,219,133,239,79,127,240,79,198,56,173,175,52,58,243,251,11,196,226,244,172,68,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("af99ba40-7ed6-49ab-b28e-17f32134e193"));
		}

		#endregion

	}

	#endregion

}

