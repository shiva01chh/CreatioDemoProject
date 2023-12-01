namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFileCacheManagerSchema

	/// <exclude/>
	public class IFileCacheManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFileCacheManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFileCacheManagerSchema(IFileCacheManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0e5e91d3-bc10-4f37-b040-4d4f5d89326c");
			Name = "IFileCacheManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3c624d29-361c-47f2-ac8f-7824eb3cde6f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,145,193,106,195,48,12,134,239,133,190,131,96,151,21,74,30,96,57,109,101,45,134,149,13,178,178,179,99,43,169,33,177,131,236,28,178,176,119,159,237,210,197,93,151,78,135,96,73,127,244,203,159,53,111,209,118,92,32,188,35,17,183,166,114,217,198,232,74,213,61,113,167,140,206,182,170,193,13,23,71,220,115,205,107,164,229,98,92,46,192,71,111,149,174,161,24,172,195,54,191,46,101,236,245,162,122,107,254,161,107,12,151,179,114,194,27,173,236,89,59,229,20,218,25,77,152,159,61,150,214,17,23,193,48,232,78,202,59,194,218,23,128,105,135,84,121,6,15,192,174,111,27,148,167,111,215,151,141,18,160,206,242,57,245,120,54,72,77,222,200,116,72,97,207,180,91,26,211,0,179,69,47,4,90,203,180,191,8,111,212,103,36,3,35,212,232,114,248,186,24,135,90,158,38,254,101,178,71,119,52,242,194,129,77,124,153,174,12,188,248,195,150,76,27,215,190,63,88,36,255,28,26,35,26,207,46,77,215,16,209,14,133,87,182,28,48,73,214,48,57,132,216,245,74,66,229,157,152,92,195,147,210,156,134,15,82,158,19,148,73,178,202,167,191,126,49,216,161,243,24,226,236,184,153,252,111,181,232,152,174,116,96,114,149,207,161,10,249,15,199,180,17,139,62,190,1,51,239,181,208,8,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0e5e91d3-bc10-4f37-b040-4d4f5d89326c"));
		}

		#endregion

	}

	#endregion

}

