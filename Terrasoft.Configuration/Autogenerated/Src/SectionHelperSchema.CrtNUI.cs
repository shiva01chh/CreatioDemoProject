namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SectionHelperSchema

	/// <exclude/>
	public class SectionHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SectionHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SectionHelperSchema(SectionHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("33d4e612-facc-4d4c-9516-d0f60d673446");
			Name = "SectionHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9defff70-969f-468c-8263-69f6e8af1009");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,81,65,110,194,48,16,60,7,137,63,88,226,2,151,60,0,218,30,154,180,180,135,86,149,2,15,112,205,146,88,74,236,104,119,83,21,161,254,189,142,141,212,4,106,174,248,182,51,187,179,51,107,35,27,160,86,42,16,27,64,148,100,247,156,102,214,236,117,217,161,100,109,205,116,114,156,78,146,142,180,41,69,113,32,134,102,117,86,167,27,248,230,11,48,179,117,13,170,87,160,116,13,6,80,171,139,158,92,178,252,3,135,6,154,198,154,255,25,132,24,158,62,25,214,172,129,162,13,207,82,177,197,72,199,123,167,163,131,249,163,163,28,217,118,159,181,86,66,213,146,72,20,33,222,11,212,45,224,82,188,142,106,113,244,3,201,12,161,116,160,120,3,174,236,142,150,226,195,75,4,242,36,71,140,253,206,53,240,232,242,133,66,221,242,124,75,128,14,55,65,93,116,163,114,209,239,73,146,228,75,162,168,194,226,123,145,245,246,66,214,131,187,61,223,141,101,135,54,31,230,139,149,23,64,224,14,205,73,35,141,88,57,219,237,39,127,98,81,106,13,134,183,70,115,161,42,104,100,14,228,69,44,210,205,34,93,177,116,37,218,12,204,46,252,162,175,29,234,137,225,251,5,119,20,58,250,70,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("33d4e612-facc-4d4c-9516-d0f60d673446"));
		}

		#endregion

	}

	#endregion

}

