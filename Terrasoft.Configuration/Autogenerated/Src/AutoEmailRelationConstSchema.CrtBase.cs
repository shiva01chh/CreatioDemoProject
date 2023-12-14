namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AutoEmailRelationConstSchema

	/// <exclude/>
	public class AutoEmailRelationConstSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AutoEmailRelationConstSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AutoEmailRelationConstSchema(AutoEmailRelationConstSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2456833a-24e8-4599-9cc4-9e4102ad1dfd");
			Name = "AutoEmailRelationConst";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0bd8020-de17-4815-83cd-c2dac7bbc324");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,201,142,219,48,12,134,207,19,32,239,32,204,92,218,3,7,164,181,88,198,160,7,199,113,138,158,10,116,166,15,160,72,116,106,192,27,188,160,48,138,190,123,53,105,79,233,102,65,7,233,23,201,15,191,200,206,181,60,13,206,179,120,225,113,116,83,95,205,143,69,223,85,245,101,25,221,92,247,221,99,190,204,125,217,186,186,249,196,205,85,217,239,190,237,119,119,203,84,119,23,241,188,78,51,183,79,241,30,247,195,200,151,248,46,138,198,77,147,248,45,47,150,157,230,253,46,6,14,203,185,169,189,152,230,168,123,225,255,25,126,247,10,187,201,24,217,133,190,107,86,241,126,169,131,40,219,161,233,87,230,15,65,188,19,29,127,189,170,111,238,13,166,82,150,167,2,78,210,28,128,20,33,228,214,74,32,115,180,178,200,15,152,89,188,127,251,244,191,234,31,151,177,232,219,193,117,235,203,58,220,50,116,170,40,57,229,71,208,178,52,112,60,17,65,150,210,1,16,233,104,176,204,164,45,204,6,70,180,58,59,63,63,251,47,220,186,207,55,12,50,103,150,70,19,216,138,19,80,164,51,176,33,32,56,139,50,40,99,101,8,114,3,35,247,190,95,186,191,48,18,29,82,79,238,12,20,24,65,105,36,56,43,76,0,19,70,214,46,77,130,225,237,62,226,127,181,75,87,251,107,27,255,12,68,84,46,163,132,32,161,202,130,114,196,96,51,138,39,237,177,74,181,97,167,104,187,169,13,64,75,94,73,101,8,208,80,6,74,133,0,22,211,104,51,77,98,11,45,90,237,127,117,234,251,117,68,31,184,11,63,199,121,191,139,202,235,250,1,181,157,72,157,43,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2456833a-24e8-4599-9cc4-9e4102ad1dfd"));
		}

		#endregion

	}

	#endregion

}

