namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ChatContactSchema

	/// <exclude/>
	public class ChatContactSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ChatContactSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ChatContactSchema(ChatContactSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9dfeee86-228f-4670-b6f8-b56e2b8c7992");
			Name = "ChatContact";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fe318069-3d3c-4328-afd6-b81d71766949");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,145,219,74,196,48,16,134,175,45,244,29,194,94,233,77,251,0,171,130,84,17,193,170,184,226,141,120,49,155,78,187,131,57,148,28,132,85,124,119,39,173,197,221,101,27,2,201,204,252,223,63,57,24,208,232,123,144,40,94,208,57,240,182,13,69,101,77,75,93,116,16,200,154,226,81,27,146,27,48,6,85,81,163,247,208,145,233,242,236,59,207,78,162,231,173,88,109,125,64,189,60,136,139,231,104,2,105,44,86,232,8,20,125,13,110,255,170,221,118,110,80,125,146,196,218,54,168,184,127,112,32,3,139,89,94,150,165,56,247,81,107,112,219,203,191,184,82,224,189,144,172,3,50,232,68,107,157,224,51,134,49,37,131,104,32,64,49,193,229,14,253,118,205,149,169,193,59,39,250,184,86,36,133,28,28,43,246,168,70,11,46,165,43,142,64,141,122,141,238,244,129,31,75,92,136,5,53,139,179,196,78,240,109,164,70,220,53,203,57,189,225,117,159,240,193,165,71,72,130,89,170,223,216,96,143,98,79,169,50,203,161,6,82,71,185,155,84,153,229,64,74,203,127,182,79,222,91,251,17,251,87,80,17,197,213,40,72,6,63,121,198,51,141,95,229,16,228,95,65,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9dfeee86-228f-4670-b6f8-b56e2b8c7992"));
		}

		#endregion

	}

	#endregion

}

