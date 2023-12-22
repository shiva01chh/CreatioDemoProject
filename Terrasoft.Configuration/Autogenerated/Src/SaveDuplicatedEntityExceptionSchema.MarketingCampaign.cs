namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SaveDuplicatedEntityExceptionSchema

	/// <exclude/>
	public class SaveDuplicatedEntityExceptionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SaveDuplicatedEntityExceptionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SaveDuplicatedEntityExceptionSchema(SaveDuplicatedEntityExceptionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b337a224-56ad-46fe-b05d-92c5ffd63b6b");
			Name = "SaveDuplicatedEntityException";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,81,61,111,194,64,12,157,131,196,127,176,232,210,46,201,78,41,11,101,232,80,169,18,252,1,147,56,225,84,114,119,58,59,77,83,212,255,94,231,18,62,202,192,109,247,228,247,225,103,139,53,177,199,156,96,75,33,32,187,82,210,149,179,165,169,154,128,98,156,77,223,49,124,146,24,91,173,176,246,104,42,59,157,28,167,147,164,97,133,96,211,177,80,253,60,157,40,242,16,168,82,2,172,14,200,60,135,13,126,209,107,227,15,38,71,161,98,109,197,72,183,254,206,201,247,170,145,144,101,25,44,184,169,107,12,221,114,252,159,39,64,246,193,181,12,237,158,44,20,39,29,160,168,3,18,186,222,94,28,24,203,20,36,61,201,101,87,122,190,217,41,11,242,62,207,253,56,48,135,171,104,201,49,198,187,44,228,44,75,104,114,113,65,247,250,136,170,195,196,237,6,17,120,179,70,12,30,204,15,49,32,88,106,251,140,130,86,59,118,165,174,69,99,107,233,197,126,136,216,26,217,43,131,61,229,166,52,84,128,94,196,5,208,3,49,86,148,158,13,179,91,199,133,199,128,53,88,189,229,203,108,28,159,45,183,234,52,126,212,21,5,10,226,60,152,157,198,234,67,68,241,116,145,69,110,148,26,251,186,219,212,163,54,209,55,63,10,63,245,188,36,153,195,14,153,30,79,32,28,225,119,172,144,108,49,180,24,255,3,250,31,84,236,250,253,1,168,132,207,212,145,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b337a224-56ad-46fe-b05d-92c5ffd63b6b"));
		}

		#endregion

	}

	#endregion

}

