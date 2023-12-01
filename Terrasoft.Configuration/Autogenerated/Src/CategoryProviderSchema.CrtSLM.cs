﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CategoryProviderSchema

	/// <exclude/>
	public class CategoryProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CategoryProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CategoryProviderSchema(CategoryProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("182aea75-3481-441c-9722-cb6c10eeec5c");
			Name = "CategoryProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,83,193,106,219,64,16,61,43,144,127,24,156,139,13,65,186,55,182,160,117,29,99,74,104,168,11,57,132,80,54,210,200,30,144,118,213,221,85,26,181,228,223,59,218,149,44,69,137,77,116,144,152,213,155,55,111,223,204,72,81,160,41,69,130,240,19,181,22,70,101,54,92,42,153,209,174,210,194,146,146,231,103,255,206,207,130,202,144,220,193,182,54,22,139,171,81,204,248,60,199,164,1,155,112,141,18,53,37,140,97,212,133,198,29,159,194,50,23,198,124,130,165,176,184,83,186,190,213,234,137,82,212,14,19,69,17,204,77,85,20,66,215,113,27,175,209,66,34,12,242,203,103,64,166,85,1,166,42,75,165,45,20,130,114,120,84,207,104,194,142,32,26,48,148,213,99,78,9,36,77,209,119,106,6,205,125,14,210,174,9,243,148,181,221,106,122,98,168,147,20,148,62,0,141,34,85,50,175,97,211,209,92,179,142,173,151,113,195,42,190,168,103,248,101,94,197,63,176,84,134,44,99,189,7,193,5,202,212,23,107,227,206,20,182,203,234,42,97,104,83,223,137,246,136,177,37,238,96,35,201,146,200,233,47,130,196,63,64,156,44,36,183,77,101,140,69,182,74,99,182,152,140,175,59,137,226,240,64,25,141,57,231,165,208,162,0,201,51,176,152,28,187,198,36,222,142,124,103,95,186,159,225,60,114,28,142,178,53,126,172,97,122,202,189,99,85,103,224,218,20,28,117,23,22,71,115,155,1,13,94,78,187,127,131,118,175,210,143,24,239,135,209,95,96,147,250,73,212,152,80,73,40,173,25,13,227,71,140,238,147,39,241,103,222,185,186,233,225,128,17,27,202,87,198,58,10,141,182,210,210,196,203,225,98,108,82,6,118,127,6,61,88,87,148,54,202,27,240,186,197,78,121,220,120,107,239,31,6,197,58,155,191,146,219,95,214,60,247,168,75,71,17,143,60,70,195,182,31,109,9,47,127,15,188,35,187,111,251,78,104,166,51,215,148,32,83,188,83,201,30,90,45,189,18,30,232,119,100,189,193,183,165,87,206,117,78,25,203,11,191,97,221,103,7,148,193,244,192,26,174,126,87,34,55,211,33,199,37,108,29,241,82,21,108,55,25,37,195,239,58,37,41,242,205,78,114,237,198,191,89,207,23,120,171,223,148,189,31,114,62,92,181,232,23,255,245,31,255,110,243,27,111,195,85,81,218,83,179,234,79,135,135,124,194,207,127,107,220,65,17,179,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("182aea75-3481-441c-9722-cb6c10eeec5c"));
		}

		#endregion

	}

	#endregion

}
