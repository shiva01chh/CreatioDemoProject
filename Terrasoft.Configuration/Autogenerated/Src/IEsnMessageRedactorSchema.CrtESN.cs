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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,213,86,77,143,218,48,16,61,131,196,127,24,209,67,119,37,148,220,91,150,11,160,21,135,126,168,32,245,108,226,9,177,54,182,145,199,41,66,85,255,123,29,199,9,97,161,187,202,2,82,55,55,219,227,55,239,189,204,139,162,152,68,218,178,4,97,133,198,48,210,169,141,166,90,165,98,83,24,102,133,86,209,124,249,117,208,255,61,232,247,10,18,106,3,203,61,89,148,159,155,245,84,27,140,230,202,10,43,144,220,182,59,248,96,112,227,110,2,44,148,69,147,58,240,79,176,152,147,250,130,68,108,131,63,144,179,196,106,227,107,227,56,134,49,21,82,50,179,159,132,245,119,163,127,9,142,4,18,109,166,57,65,170,13,144,78,4,203,65,161,221,105,243,4,198,131,148,4,100,133,74,81,141,22,183,224,182,197,58,23,9,136,154,200,121,30,189,82,222,9,149,138,139,38,11,88,202,219,127,164,186,87,212,148,199,207,235,199,91,102,152,4,229,108,125,24,134,242,25,179,108,56,9,93,129,187,85,52,142,125,93,115,109,39,108,6,54,67,200,48,223,130,78,29,17,68,72,12,166,15,67,199,248,167,17,22,3,192,108,245,109,24,79,60,133,199,66,112,207,48,28,221,157,150,66,139,195,125,245,122,94,16,26,138,157,210,68,75,233,100,119,84,186,224,7,157,11,126,162,242,232,74,232,80,153,51,173,22,55,49,39,96,223,249,141,134,232,8,206,152,213,226,244,162,89,115,46,46,158,138,131,83,187,76,19,172,17,208,161,226,43,174,29,141,212,210,154,86,2,186,249,230,201,215,94,173,181,206,189,168,102,144,252,113,141,60,2,58,234,244,94,252,105,71,238,245,161,185,161,125,23,228,210,91,249,230,92,134,242,67,192,186,120,121,148,208,48,107,117,255,231,23,223,226,86,29,204,224,86,128,110,134,173,83,24,255,3,135,218,223,176,238,211,118,77,3,47,248,178,205,48,71,139,215,207,46,247,184,167,118,118,149,93,241,59,159,179,91,10,251,231,152,92,87,216,249,55,90,10,235,253,169,254,173,80,241,234,247,106,208,119,59,229,243,23,92,207,179,216,195,9,0,0 };
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

