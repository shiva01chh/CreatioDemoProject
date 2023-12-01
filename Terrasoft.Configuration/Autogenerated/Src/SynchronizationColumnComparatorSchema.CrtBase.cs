namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SynchronizationColumnComparatorSchema

	/// <exclude/>
	public class SynchronizationColumnComparatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SynchronizationColumnComparatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SynchronizationColumnComparatorSchema(SynchronizationColumnComparatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e35d3e1f-66cd-49ce-837d-7492da9c21e7");
			Name = "SynchronizationColumnComparator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,146,63,79,196,48,12,197,103,42,221,119,176,142,5,36,212,236,80,186,92,25,152,15,177,167,173,91,114,74,236,226,36,72,5,241,221,233,191,19,168,119,136,133,197,210,179,222,203,207,145,77,218,161,239,116,133,240,132,34,218,115,19,210,29,83,99,218,40,58,24,166,244,129,130,9,253,190,167,234,69,152,204,251,212,221,36,31,155,100,147,92,92,10,182,131,132,2,45,182,58,224,45,172,140,59,182,209,13,213,117,122,120,143,101,74,41,165,32,243,209,57,45,125,190,232,2,3,138,51,132,30,76,3,217,104,119,130,13,208,48,224,253,214,115,148,10,159,181,141,184,85,57,24,15,248,26,181,133,192,39,214,26,125,48,52,193,103,127,158,30,145,106,197,156,163,103,16,249,126,18,240,54,170,52,83,147,239,108,234,148,86,124,119,126,201,11,134,40,228,243,199,255,254,103,166,142,79,15,168,46,150,214,84,80,47,155,129,146,217,254,181,157,43,46,15,88,5,248,49,198,13,44,189,53,239,250,110,190,0,164,122,62,130,81,126,142,37,73,190,0,72,239,233,67,86,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e35d3e1f-66cd-49ce-837d-7492da9c21e7"));
		}

		#endregion

	}

	#endregion

}

