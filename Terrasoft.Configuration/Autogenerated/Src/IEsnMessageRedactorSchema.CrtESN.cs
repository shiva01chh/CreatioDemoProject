namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IEsnMessageRedactorSchema

	/// <exclude/>
	public class IEsnMessageRedactorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IEsnMessageRedactorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IEsnMessageRedactorSchema(IEsnMessageRedactorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("95f9fa02-7c86-4d9f-a8c2-7614daa3758a");
			Name = "IEsnMessageRedactor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,213,86,193,110,226,48,16,61,131,196,63,140,232,161,93,169,74,238,91,202,5,208,138,67,219,213,82,169,103,19,79,136,181,177,141,60,78,17,90,245,223,107,28,39,132,66,91,165,128,212,205,205,246,248,205,123,47,243,162,40,38,145,150,44,65,120,68,99,24,233,212,70,35,173,82,177,40,12,179,66,171,104,50,187,239,117,255,245,186,157,130,132,90,192,108,77,22,229,77,189,30,105,131,209,68,89,97,5,146,219,118,7,23,6,23,238,38,192,84,89,52,169,3,255,9,211,9,169,59,36,98,11,252,131,156,37,86,27,95,27,199,49,12,168,144,146,153,245,48,172,127,27,253,44,56,18,72,180,153,230,4,169,54,64,58,17,44,7,133,118,165,205,95,48,30,100,67,64,150,168,20,85,104,113,3,110,89,204,115,145,128,168,136,28,230,209,217,200,219,163,82,114,209,100,1,55,242,214,151,84,245,138,234,242,248,109,253,96,201,12,147,160,156,173,183,253,80,62,102,150,245,135,161,43,112,183,138,6,177,175,171,175,173,132,205,192,102,8,25,230,75,208,169,35,130,8,137,193,244,182,239,24,63,25,97,49,0,140,31,31,250,241,208,83,248,85,8,238,25,134,163,171,253,82,104,112,248,81,190,158,15,132,134,98,167,52,209,82,58,217,45,149,78,249,86,231,148,239,169,220,185,18,58,148,230,140,202,197,89,204,9,216,87,126,163,38,122,13,7,204,106,112,250,208,172,9,23,71,79,197,214,169,85,166,9,230,8,232,80,241,19,215,118,70,106,102,77,35,1,237,124,243,228,43,175,230,90,231,94,84,61,72,254,184,66,190,6,218,233,244,191,248,211,140,220,231,67,115,70,251,142,200,165,183,242,203,185,12,229,219,128,181,241,114,39,161,97,214,170,254,111,47,126,197,173,42,152,193,173,0,93,15,91,171,48,126,3,135,154,223,176,246,211,118,74,3,143,248,178,141,49,71,139,167,207,46,247,184,251,118,182,149,93,242,59,156,179,115,10,123,119,76,78,43,236,240,27,221,8,235,188,148,255,86,168,120,249,123,213,235,186,157,230,243,10,166,159,174,222,203,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("95f9fa02-7c86-4d9f-a8c2-7614daa3758a"));
		}

		#endregion

	}

	#endregion

}

