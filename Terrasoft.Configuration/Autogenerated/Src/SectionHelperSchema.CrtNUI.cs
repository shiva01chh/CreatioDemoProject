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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,81,65,110,194,48,16,60,7,137,63,88,226,2,151,60,0,218,30,74,90,218,67,171,74,129,7,184,102,73,44,57,118,180,187,174,138,80,255,94,199,65,42,129,154,43,190,237,204,238,236,204,218,202,6,168,149,10,196,26,16,37,185,29,231,75,103,119,186,242,40,89,59,59,30,29,198,163,204,147,182,149,40,247,196,208,44,206,234,124,13,223,124,1,46,157,49,160,58,5,202,87,96,1,181,186,232,41,36,203,63,240,212,64,211,56,251,63,131,144,194,243,39,203,154,53,80,178,225,89,42,118,152,232,120,247,58,57,88,60,6,42,144,173,255,52,90,9,101,36,145,40,251,120,47,96,90,192,185,120,29,212,226,16,7,178,9,66,21,64,241,6,92,187,45,205,197,71,148,232,201,163,28,49,118,59,87,192,131,203,151,10,117,203,211,13,1,6,220,246,234,194,15,202,89,183,39,203,178,47,137,162,238,23,223,139,101,103,175,207,186,15,183,231,187,161,236,169,205,135,233,108,17,5,16,216,163,61,106,228,9,43,103,187,227,228,79,42,138,209,96,121,99,53,151,170,134,70,22,64,81,196,33,221,44,210,21,75,87,162,77,192,110,251,95,140,117,64,35,209,189,95,15,55,140,201,62,3,0,0 };
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

