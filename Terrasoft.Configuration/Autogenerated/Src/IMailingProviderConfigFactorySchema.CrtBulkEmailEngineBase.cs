namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMailingProviderConfigFactorySchema

	/// <exclude/>
	public class IMailingProviderConfigFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMailingProviderConfigFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMailingProviderConfigFactorySchema(IMailingProviderConfigFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e17ee573-06a4-435b-80a1-7eb5968f81d8");
			Name = "IMailingProviderConfigFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5d774dd3-3f0d-4e5d-9409-9a3b17d3417e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,146,77,106,195,48,16,133,215,49,248,14,194,221,180,155,104,159,56,222,4,10,94,4,66,105,15,160,202,35,71,16,75,102,36,23,66,232,221,59,150,228,214,110,3,165,245,70,104,126,222,251,70,99,35,58,112,189,144,192,158,1,81,56,171,252,122,111,141,210,237,128,194,107,107,242,236,154,103,171,193,105,211,46,74,16,182,121,70,153,59,132,150,202,88,109,60,160,34,161,13,171,15,66,159,169,254,136,246,77,55,128,81,239,81,72,111,241,18,154,56,231,172,116,67,215,9,188,84,233,158,170,29,235,192,159,108,227,152,178,200,36,2,81,144,181,54,206,11,35,53,229,173,98,254,4,212,15,48,230,213,174,184,109,88,240,106,61,121,241,153,89,63,188,158,181,36,197,4,252,27,239,234,26,152,63,39,61,68,190,13,59,6,161,152,252,62,81,8,236,71,122,34,78,240,240,87,244,159,236,49,210,11,20,29,51,180,186,93,49,184,208,100,64,142,219,42,170,122,230,53,243,121,89,150,145,126,201,131,204,151,42,130,31,208,184,234,41,158,255,163,46,249,36,51,234,222,174,75,239,50,145,222,47,217,216,114,162,135,109,122,125,48,77,92,64,184,191,199,159,111,17,12,49,250,62,0,193,136,8,104,212,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e17ee573-06a4-435b-80a1-7eb5968f81d8"));
		}

		#endregion

	}

	#endregion

}

