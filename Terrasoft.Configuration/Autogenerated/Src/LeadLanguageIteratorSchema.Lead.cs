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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,81,77,107,194,64,16,61,71,240,63,12,233,69,161,36,119,191,160,181,23,65,104,41,245,84,122,24,215,73,88,216,236,134,253,160,88,241,191,119,178,137,86,83,193,192,18,102,230,189,55,111,102,52,86,228,106,20,4,31,100,45,58,83,248,108,105,116,33,203,96,209,75,163,135,131,195,112,144,4,39,117,121,5,177,52,29,14,184,242,96,169,100,24,44,21,58,55,129,215,186,54,214,7,45,253,126,141,186,12,88,210,202,19,75,25,27,225,121,158,195,204,133,170,66,187,95,116,241,9,0,5,63,37,157,111,122,109,247,160,8,119,160,58,21,151,157,216,249,5,189,14,91,37,5,136,166,57,172,25,223,111,10,19,120,70,71,255,189,36,135,232,231,207,191,209,206,219,32,184,200,99,188,69,221,22,209,183,220,122,230,9,37,42,249,67,14,52,125,131,100,54,106,94,163,41,24,76,4,194,82,49,79,111,89,74,243,69,6,103,225,188,175,60,171,209,98,5,154,15,51,79,131,35,203,206,52,137,230,22,233,98,195,49,136,115,34,155,229,17,29,201,221,46,110,181,28,109,174,116,224,90,118,220,176,147,100,2,91,222,212,168,87,131,67,172,158,20,223,131,226,137,231,113,230,213,101,242,243,171,67,38,77,137,5,60,10,191,210,151,110,26,88,207,201,248,17,110,144,158,132,48,65,251,187,220,63,234,11,21,24,148,191,143,62,78,155,223,177,187,61,233,93,123,254,24,183,217,235,36,231,248,251,5,21,66,126,148,38,3,0,0 };
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

