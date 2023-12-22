namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EsnFileDTOSchema

	/// <exclude/>
	public class EsnFileDTOSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EsnFileDTOSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EsnFileDTOSchema(EsnFileDTOSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2758fa81-89e1-4095-893e-aa49fad22cb4");
			Name = "EsnFileDTO";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f0db0304-dc6c-40c0-a3bb-97ab97632500");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,144,207,110,194,48,12,198,207,32,241,14,22,92,182,75,31,0,180,83,129,137,3,127,180,114,155,118,48,141,169,44,181,105,229,56,135,129,246,238,75,82,13,1,98,18,57,36,242,231,207,63,219,1,139,13,185,14,75,130,61,137,160,107,143,154,229,173,61,114,229,5,149,91,155,45,138,205,104,120,30,13,7,222,177,173,160,248,118,74,205,236,46,206,62,188,85,110,40,43,72,24,107,62,165,218,224,10,190,137,80,21,2,200,107,116,110,10,11,103,151,92,211,124,191,77,217,207,57,42,134,142,42,88,234,87,16,58,127,168,185,132,50,186,111,204,131,56,196,133,182,147,182,35,81,166,128,220,165,146,132,235,121,107,106,14,36,47,155,176,28,188,193,120,101,198,175,17,253,199,126,247,108,96,101,224,12,21,233,12,92,188,126,254,47,143,239,45,192,169,196,221,147,225,73,72,193,167,59,8,91,133,168,62,75,200,133,80,201,108,237,195,89,46,217,71,184,9,89,211,255,91,136,122,237,90,10,202,245,249,5,239,166,167,117,21,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2758fa81-89e1-4095-893e-aa49fad22cb4"));
		}

		#endregion

	}

	#endregion

}

