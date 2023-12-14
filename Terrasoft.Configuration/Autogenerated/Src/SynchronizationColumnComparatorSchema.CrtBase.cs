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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,82,61,79,195,48,16,157,137,148,255,112,42,11,72,85,188,67,200,210,116,96,46,98,119,146,75,112,101,251,194,217,70,10,136,255,142,243,81,129,210,34,22,60,156,244,158,222,187,119,214,157,149,6,93,47,107,132,39,100,150,142,90,159,237,200,182,170,11,44,189,34,155,237,173,87,126,56,12,182,126,97,178,234,125,98,211,228,35,77,210,228,234,154,177,139,16,74,212,216,73,143,119,176,18,238,72,7,19,171,233,101,236,71,60,185,132,16,144,187,96,140,228,161,88,112,137,30,217,40,139,14,84,11,249,40,55,140,45,216,56,224,195,198,81,224,26,159,165,14,184,17,5,40,7,248,26,164,6,79,103,210,6,157,87,118,10,159,245,69,118,138,20,171,204,217,122,33,162,56,76,0,222,70,148,229,98,210,93,116,157,167,149,223,204,47,126,70,31,216,186,226,241,191,255,153,139,83,235,24,213,135,74,171,26,154,101,51,80,17,233,191,182,115,67,213,17,107,15,63,198,216,194,194,173,243,110,239,231,11,64,219,204,71,48,194,207,177,196,247,5,222,38,147,74,87,2,0,0 };
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

