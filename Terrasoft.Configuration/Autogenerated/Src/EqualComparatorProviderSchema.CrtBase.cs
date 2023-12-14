namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EqualComparatorProviderSchema

	/// <exclude/>
	public class EqualComparatorProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EqualComparatorProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EqualComparatorProviderSchema(EqualComparatorProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ebef606a-f1e5-4bdb-b9fe-2515dda709fc");
			Name = "EqualComparatorProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,84,203,78,194,64,20,93,67,194,63,92,67,98,74,98,218,189,128,46,128,24,23,42,17,227,126,104,111,97,76,59,83,231,97,82,31,255,238,116,102,90,75,169,46,76,148,77,51,231,222,115,206,125,5,70,114,148,5,137,17,30,80,8,34,121,170,194,5,103,41,221,105,65,20,229,44,92,49,69,85,185,41,89,188,23,156,209,87,139,142,134,111,163,225,104,56,208,146,178,29,108,74,169,48,159,90,100,44,112,103,18,96,145,17,41,207,97,245,172,73,182,224,121,65,140,28,23,107,193,95,104,130,194,166,70,81,4,51,169,243,156,136,242,194,191,125,130,132,184,225,72,72,185,128,132,166,41,10,100,10,84,89,160,12,107,126,212,18,40,244,54,163,49,196,149,245,119,206,112,14,215,223,22,53,112,93,53,77,220,160,218,243,196,180,177,182,202,46,216,45,219,2,247,168,180,96,18,176,146,110,21,111,107,151,74,152,49,133,13,57,234,178,103,194,209,47,190,138,10,103,81,13,86,89,190,181,206,26,22,60,211,57,251,34,193,21,170,141,53,235,180,24,76,224,173,146,25,56,77,72,48,195,29,81,24,240,237,19,198,10,36,215,34,198,71,146,105,60,3,143,153,45,40,202,172,143,13,212,18,181,70,208,34,193,201,28,152,206,50,56,61,61,226,181,99,45,74,104,75,148,193,145,205,196,185,12,222,223,141,133,155,220,181,188,53,2,119,98,149,23,170,12,60,58,105,137,77,172,248,79,201,199,54,83,235,243,97,63,31,191,93,109,98,134,248,64,115,252,167,229,46,141,221,95,174,118,233,219,185,244,180,250,13,115,8,154,88,123,240,211,46,175,37,221,79,238,122,79,251,142,170,161,246,223,85,55,236,47,166,57,176,58,30,186,75,171,158,61,231,214,147,117,120,124,157,17,252,92,138,15,247,157,213,24,89,226,254,81,236,219,161,135,160,197,170,223,39,209,44,84,133,145,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ebef606a-f1e5-4bdb-b9fe-2515dda709fc"));
		}

		#endregion

	}

	#endregion

}

