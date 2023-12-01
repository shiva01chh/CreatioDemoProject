namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseLanguageIteratorSchema

	/// <exclude/>
	public class BaseLanguageIteratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseLanguageIteratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseLanguageIteratorSchema(BaseLanguageIteratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("88e0be6b-543f-42a7-9c74-8a6542583cb1");
			Name = "BaseLanguageIterator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("2659875a-4670-491c-9c1f-f4641a7bae64");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,84,77,139,219,48,16,61,103,97,255,195,224,189,164,23,251,190,77,2,109,40,193,176,11,75,63,78,165,7,69,30,123,5,182,108,70,82,139,91,250,223,59,82,108,87,118,178,33,62,89,147,167,55,243,222,60,71,139,6,77,39,36,194,87,36,18,166,45,109,186,111,117,169,42,71,194,170,86,223,223,253,185,191,91,57,163,116,5,95,122,99,177,121,191,56,51,190,174,81,122,176,73,15,168,145,148,252,143,137,105,9,185,206,191,60,16,86,140,134,125,45,140,121,132,143,194,224,147,208,149,19,21,230,22,185,111,75,1,151,101,25,108,140,107,26,65,253,110,56,123,48,23,17,65,18,150,219,36,95,222,76,178,29,168,166,171,177,65,109,131,132,116,164,202,34,174,206,29,107,37,65,28,141,37,33,45,72,63,203,197,81,224,17,206,154,48,129,183,101,82,242,66,109,135,100,21,178,156,151,192,28,4,156,41,8,133,111,6,9,100,171,245,201,180,116,2,198,243,141,3,122,240,126,194,46,143,97,136,85,133,214,27,190,250,123,165,233,7,94,67,15,109,9,245,32,5,200,213,104,174,55,159,116,127,102,236,247,31,16,31,77,212,28,204,124,130,7,212,197,201,153,225,60,46,156,35,98,201,73,118,208,27,69,173,101,29,88,92,25,59,215,202,42,81,171,223,220,79,227,47,80,76,32,52,199,149,149,68,41,184,180,55,14,194,27,234,66,165,19,36,26,208,156,255,109,226,102,174,38,187,229,134,54,89,64,159,172,25,167,190,24,150,245,98,65,115,230,119,131,103,11,208,118,1,187,197,202,103,180,175,109,113,75,220,14,104,205,180,117,3,199,30,248,195,80,182,7,85,248,151,82,33,221,234,19,161,108,169,200,139,100,247,233,140,34,246,40,92,36,180,142,180,97,168,107,134,47,41,138,159,225,11,35,34,78,220,128,62,214,184,57,56,85,236,252,248,163,201,102,237,75,48,78,49,186,89,242,31,139,144,175,176,254,41,40,164,154,83,50,143,234,136,92,245,10,107,79,224,251,6,104,26,209,231,197,122,162,14,43,240,59,120,107,17,167,234,188,200,53,126,254,1,55,213,197,238,83,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("88e0be6b-543f-42a7-9c74-8a6542583cb1"));
		}

		#endregion

	}

	#endregion

}

