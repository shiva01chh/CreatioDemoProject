﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ContactLanguageIteratorSchema

	/// <exclude/>
	public class ContactLanguageIteratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ContactLanguageIteratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ContactLanguageIteratorSchema(ContactLanguageIteratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0cad4a31-9d11-4174-aee6-2df7a00ccdc7");
			Name = "ContactLanguageIterator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d5fe5418-b108-401a-ba83-ff1213a966db");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,145,77,107,195,48,12,134,207,41,244,63,136,244,178,194,136,239,253,58,172,187,20,118,24,99,61,141,29,84,79,9,6,199,41,254,96,116,163,255,125,178,147,126,36,165,176,66,40,150,94,61,122,37,25,172,201,237,81,18,188,147,181,232,154,210,23,235,198,148,170,10,22,189,106,204,120,244,59,30,101,193,41,83,245,36,150,230,227,17,103,38,150,42,150,193,90,163,115,51,224,90,143,210,191,160,169,2,86,180,241,196,152,198,38,169,16,2,22,46,212,53,218,195,170,123,159,4,80,242,167,149,243,177,207,238,0,178,229,128,238,64,174,56,1,196,21,97,31,118,90,73,144,177,247,189,214,48,131,39,116,116,235,40,139,131,93,252,55,198,121,27,36,167,120,140,215,4,78,174,111,108,183,190,141,242,10,181,250,33,7,134,190,65,113,53,26,94,99,83,178,152,8,164,165,114,153,223,241,148,139,85,1,103,182,24,194,23,123,180,88,131,225,219,44,243,224,200,50,198,144,140,231,200,87,91,126,199,245,116,129,98,33,146,58,21,119,251,184,211,245,97,219,67,65,159,60,141,128,108,6,59,94,214,195,32,5,105,85,217,9,248,22,52,143,189,76,131,111,174,131,31,159,157,50,139,169,115,127,51,48,20,165,3,51,211,199,75,221,51,149,24,244,63,212,199,121,252,59,182,103,154,144,249,106,111,153,222,109,180,31,228,24,255,254,0,235,62,21,16,243,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0cad4a31-9d11-4174-aee6-2df7a00ccdc7"));
		}

		#endregion

	}

	#endregion

}

