namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFileImportValidationServiceSchema

	/// <exclude/>
	public class IFileImportValidationServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFileImportValidationServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFileImportValidationServiceSchema(IFileImportValidationServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cb43cabf-2447-44e4-b1b4-3716ee0c72e1");
			Name = "IFileImportValidationService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,81,203,106,195,48,16,60,59,144,127,88,156,139,3,198,31,144,210,75,11,1,23,220,132,56,52,135,144,131,98,175,93,81,91,82,37,57,96,74,255,189,107,203,206,3,138,117,17,26,205,236,204,238,10,86,163,81,44,67,216,163,214,204,200,194,70,175,82,20,188,108,52,179,92,138,104,205,43,140,107,37,181,157,207,126,230,51,175,49,92,148,144,182,198,98,29,165,168,47,60,195,68,230,88,61,77,125,70,7,60,19,129,40,11,141,37,213,133,88,88,212,5,57,175,32,190,121,124,176,138,231,189,241,160,238,53,199,225,65,201,172,102,153,13,222,41,54,60,131,63,33,244,151,39,82,170,230,92,241,12,248,104,54,233,5,36,232,90,188,102,76,208,126,202,220,172,96,219,151,233,179,120,199,141,66,55,155,49,206,169,135,169,195,88,92,228,23,6,78,214,229,219,110,210,189,31,194,14,191,27,52,118,45,117,205,44,225,68,77,208,24,86,162,131,162,55,35,69,8,47,50,111,83,219,86,248,64,185,162,209,65,51,165,48,15,59,59,207,219,209,226,164,48,56,93,181,159,130,247,95,211,163,30,6,8,131,27,107,24,200,144,27,180,187,151,110,131,222,2,69,238,38,68,175,95,183,213,59,136,144,251,243,7,229,165,223,46,99,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cb43cabf-2447-44e4-b1b4-3716ee0c72e1"));
		}

		#endregion

	}

	#endregion

}

