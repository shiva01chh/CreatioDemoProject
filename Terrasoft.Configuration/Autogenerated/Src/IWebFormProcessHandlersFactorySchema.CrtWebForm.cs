namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IWebFormProcessHandlersFactorySchema

	/// <exclude/>
	public class IWebFormProcessHandlersFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IWebFormProcessHandlersFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IWebFormProcessHandlersFactorySchema(IWebFormProcessHandlersFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("30248ea6-6ed0-4ae8-b005-c4b54f120925");
			Name = "IWebFormProcessHandlersFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9d05c8ee-17e3-41aa-adfe-7e36f0a4c27c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,221,83,193,106,195,48,12,61,183,208,127,16,237,101,131,145,220,219,44,151,177,118,57,12,10,235,216,217,77,148,212,16,219,65,182,25,97,236,223,103,59,109,214,52,133,13,118,91,78,214,147,244,164,247,236,72,38,80,55,44,71,216,33,17,211,170,52,209,131,146,37,175,44,49,195,149,156,77,63,102,211,137,213,92,86,240,210,106,131,98,117,17,187,250,186,198,220,23,235,104,131,18,137,231,223,53,231,180,132,14,119,153,5,97,229,170,33,147,6,169,116,195,151,144,189,225,126,173,72,108,73,229,168,245,19,147,69,141,164,215,44,55,138,218,208,21,199,49,36,218,10,193,168,77,143,241,49,15,165,34,168,208,24,63,177,233,40,224,112,228,128,2,27,148,133,79,185,153,53,235,142,13,171,16,80,26,110,218,232,68,30,159,177,55,118,95,243,28,248,105,197,31,55,156,120,159,122,105,207,104,14,170,208,75,216,6,158,32,96,164,32,0,27,52,26,204,1,221,222,56,218,61,234,219,226,203,190,164,97,196,4,72,119,129,247,115,171,145,220,181,201,238,26,230,233,206,241,121,12,242,30,140,146,56,116,92,39,120,239,196,101,69,215,235,66,239,169,0,94,120,143,74,142,52,238,39,52,150,164,78,147,248,116,242,169,236,81,90,129,196,246,53,38,89,120,14,204,96,209,155,135,67,255,82,175,127,132,234,155,215,129,32,24,234,187,243,115,38,27,203,11,232,247,190,93,253,202,99,165,205,255,55,217,137,188,230,242,8,254,131,205,11,247,71,117,79,61,196,159,221,127,61,0,3,230,191,47,181,60,81,193,100,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("30248ea6-6ed0-4ae8-b005-c4b54f120925"));
		}

		#endregion

	}

	#endregion

}

