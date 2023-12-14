namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LeadLanguageIteratorSchema

	/// <exclude/>
	public class LeadLanguageIteratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LeadLanguageIteratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LeadLanguageIteratorSchema(LeadLanguageIteratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1252c774-91a4-464b-aa1f-d627521faa81");
			Name = "LeadLanguageIterator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("df5a8bee-e0f6-4225-b7c8-127f6fd1b1ca");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,81,77,107,194,64,16,61,71,240,63,12,233,69,161,36,119,191,160,181,23,65,104,41,245,84,122,24,215,73,88,72,118,195,126,80,172,248,223,59,187,137,86,83,193,192,18,102,230,189,55,111,102,20,214,100,27,20,4,31,100,12,90,93,184,108,169,85,33,75,111,208,73,173,134,131,195,112,144,120,43,85,121,5,49,52,29,14,184,242,96,168,100,24,44,43,180,118,2,175,77,163,141,243,74,186,253,26,85,233,177,164,149,35,150,210,38,194,243,60,135,153,245,117,141,102,191,232,226,19,0,10,126,149,180,46,244,218,238,161,34,220,65,213,169,216,236,196,206,47,232,141,223,86,82,128,8,205,97,205,248,126,83,152,192,51,90,250,239,37,57,68,63,127,254,181,178,206,120,193,69,30,227,45,234,182,136,190,229,214,51,79,40,177,146,63,100,65,209,55,72,102,163,226,53,234,130,193,68,32,12,21,243,244,150,165,52,95,100,112,22,206,251,202,179,6,13,214,160,248,48,243,212,91,50,236,76,145,8,183,72,23,27,142,65,156,19,217,44,143,232,72,238,118,113,171,229,104,115,165,3,215,178,227,192,78,146,9,108,121,83,163,94,13,14,177,122,82,124,247,21,79,60,143,51,175,46,147,159,95,29,50,9,37,22,112,40,220,74,93,186,9,176,158,147,241,35,220,32,61,9,161,189,114,119,185,127,212,23,42,208,87,238,62,250,56,13,191,99,119,123,82,187,246,252,49,110,179,215,73,206,133,239,23,58,156,158,95,39,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1252c774-91a4-464b-aa1f-d627521faa81"));
		}

		#endregion

	}

	#endregion

}

