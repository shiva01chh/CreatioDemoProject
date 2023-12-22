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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,82,61,79,196,48,12,157,169,212,255,96,29,11,72,168,217,161,116,185,50,48,31,98,79,91,183,4,37,118,113,18,164,3,241,223,233,215,137,83,239,16,11,25,44,189,167,247,252,28,217,164,29,250,94,215,8,79,40,162,61,183,33,219,50,181,166,139,162,131,97,202,30,40,152,176,223,237,169,126,17,38,243,49,177,105,242,153,38,105,114,113,41,216,13,16,74,180,216,233,128,183,176,18,110,217,70,55,84,215,235,161,31,203,228,82,74,65,238,163,115,90,246,197,130,75,12,40,206,16,122,48,45,228,163,220,9,182,64,195,128,247,27,207,81,106,124,214,54,226,70,21,96,60,224,91,212,22,2,159,72,27,244,193,208,20,62,235,139,236,16,169,86,153,179,245,76,68,177,155,0,188,143,40,203,213,164,59,235,58,77,43,127,152,95,252,130,33,10,249,226,241,191,255,153,171,67,235,33,170,143,149,53,53,52,203,102,160,98,182,127,109,231,138,171,87,172,3,28,141,113,3,11,183,206,187,190,155,47,0,169,153,143,96,132,95,99,57,122,223,131,143,226,245,95,2,0,0 };
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

