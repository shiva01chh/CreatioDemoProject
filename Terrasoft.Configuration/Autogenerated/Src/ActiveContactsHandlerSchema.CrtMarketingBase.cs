﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ActiveContactsHandlerSchema

	/// <exclude/>
	public class ActiveContactsHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ActiveContactsHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ActiveContactsHandlerSchema(ActiveContactsHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("04254b55-445c-47ce-8586-c38b9896b0a9");
			Name = "ActiveContactsHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4de4a012-9259-439f-964b-fe58905ea24f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,148,93,107,219,48,20,134,175,93,232,127,56,184,55,73,23,156,238,54,253,24,93,232,182,142,117,4,186,94,141,49,84,251,36,86,177,37,115,36,167,31,33,255,125,71,178,236,218,33,165,44,144,96,73,57,239,121,222,163,55,81,162,68,83,137,20,225,23,18,9,163,151,54,153,107,181,148,171,154,132,149,90,29,30,108,14,15,162,218,72,181,130,219,103,99,177,60,237,214,253,18,66,222,231,147,35,194,21,151,193,188,16,198,204,224,50,181,114,141,172,104,69,106,205,55,161,178,2,201,127,113,58,157,194,153,169,203,82,208,243,69,88,135,115,88,106,2,155,35,112,77,45,10,249,226,73,64,47,221,6,203,65,26,244,146,86,103,218,19,170,234,251,66,166,144,58,128,253,253,97,6,159,133,193,27,33,11,182,209,65,69,206,233,171,1,173,140,21,202,178,137,5,201,181,176,232,177,163,170,89,56,6,99,193,88,114,147,152,147,86,87,79,21,161,49,174,246,28,226,19,56,129,99,248,196,239,227,184,153,76,116,132,42,107,196,195,58,116,90,144,174,144,172,68,223,74,91,76,45,102,195,102,161,205,223,138,116,202,61,126,242,173,185,38,151,97,62,56,180,185,104,190,229,250,58,137,160,8,122,205,247,37,179,78,109,209,19,243,214,163,21,90,216,16,218,154,212,160,215,233,214,29,111,247,51,61,232,251,119,120,222,3,249,30,20,246,64,4,241,1,192,91,115,188,65,155,235,204,13,209,39,160,57,220,141,153,223,152,19,178,3,3,210,95,49,135,159,163,229,242,150,55,81,72,186,194,233,110,229,89,37,72,148,160,152,233,60,174,13,18,123,84,236,138,251,199,23,215,61,57,119,230,50,18,14,147,179,169,175,244,66,33,161,221,24,214,90,102,129,169,149,24,221,13,180,97,216,106,28,70,101,233,57,60,69,33,204,183,105,142,89,205,30,238,44,175,93,166,146,70,216,37,148,231,60,26,10,77,118,146,59,105,239,194,63,124,37,93,87,205,170,105,18,245,34,51,1,85,23,197,4,44,213,216,124,142,79,7,40,175,4,63,244,42,185,86,75,253,69,83,41,236,40,254,189,247,87,153,12,39,240,103,230,16,96,115,178,133,24,62,180,0,177,251,107,8,201,132,205,199,45,152,96,56,139,123,236,61,204,0,181,133,84,216,52,135,209,213,83,138,149,31,41,182,79,227,157,25,14,193,175,136,52,253,47,185,47,130,199,92,22,216,18,186,160,179,145,214,199,67,227,141,169,59,142,206,64,59,72,155,147,126,12,252,111,231,191,217,29,110,250,61,126,253,3,147,14,105,110,223,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("04254b55-445c-47ce-8586-c38b9896b0a9"));
		}

		#endregion

	}

	#endregion

}
