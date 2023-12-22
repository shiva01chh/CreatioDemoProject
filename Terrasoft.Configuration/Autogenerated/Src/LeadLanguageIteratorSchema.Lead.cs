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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,81,203,106,195,64,12,60,59,144,127,16,238,37,129,98,223,243,130,54,189,4,2,45,165,57,149,30,148,141,108,22,236,93,179,15,74,26,242,239,149,215,78,106,187,129,24,22,35,105,102,52,146,20,150,100,43,20,4,31,100,12,90,157,185,100,173,85,38,115,111,208,73,173,198,163,211,120,20,121,43,85,222,131,24,154,143,71,92,121,48,148,51,12,214,5,90,59,131,215,170,210,198,121,37,221,113,139,42,247,152,211,198,17,75,105,19,224,105,154,194,194,250,178,68,115,92,181,241,5,0,25,191,66,90,87,247,218,31,161,32,60,64,209,170,216,228,194,78,59,244,202,239,11,41,64,212,205,97,203,248,97,83,152,193,51,90,250,239,37,58,5,63,127,254,181,178,206,120,193,69,30,227,45,232,54,136,161,229,198,51,79,40,177,144,63,100,65,209,55,72,102,163,226,53,234,140,193,68,32,12,101,203,248,150,165,56,93,37,112,21,78,135,202,139,10,13,150,160,248,48,203,216,91,50,236,76,145,168,111,17,175,118,28,131,184,38,146,69,26,208,129,220,238,226,86,203,201,174,167,3,125,217,105,205,142,162,25,236,121,83,147,65,13,78,161,122,81,124,247,5,79,188,12,51,111,186,201,207,175,22,25,213,37,22,112,40,220,70,117,221,212,176,129,147,233,35,220,32,61,9,161,189,114,119,185,127,212,23,202,208,23,238,62,250,60,175,127,231,246,246,164,14,205,249,67,220,100,251,73,206,117,191,95,218,191,227,98,47,3,0,0 };
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

