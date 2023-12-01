﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SysInstalledAppListenerSchema

	/// <exclude/>
	public class SysInstalledAppListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SysInstalledAppListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SysInstalledAppListenerSchema(SysInstalledAppListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("199b1a31-e071-4246-9057-1443d88896db");
			Name = "SysInstalledAppListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3c624d29-361c-47f2-ac8f-7824eb3cde6f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,229,87,75,111,219,56,16,62,59,64,255,3,171,2,169,4,24,242,61,113,12,56,94,187,107,32,143,162,246,238,165,232,129,150,198,54,183,18,169,37,41,215,106,144,255,190,67,82,178,101,73,78,211,61,21,232,37,136,200,153,111,102,190,121,209,156,166,160,50,26,1,89,130,148,84,137,181,14,39,130,175,217,38,151,84,51,193,195,69,161,230,92,105,154,36,16,143,179,236,35,141,190,210,13,188,185,120,122,115,209,203,21,227,27,130,18,26,210,235,198,55,194,160,74,100,48,84,248,1,56,72,22,181,100,238,24,255,247,120,88,119,65,66,136,214,18,22,81,135,48,94,41,45,105,9,183,40,120,180,149,130,179,239,246,246,127,32,252,77,19,22,83,45,164,234,86,78,211,23,96,167,92,51,205,224,140,106,77,32,156,238,128,235,154,156,189,157,161,19,66,158,232,55,72,38,55,175,77,7,66,32,200,59,9,27,188,36,147,132,42,117,213,68,187,99,200,53,242,111,69,7,131,1,25,170,60,77,169,44,70,229,119,37,64,214,66,146,247,13,237,247,4,76,52,5,1,27,75,88,97,12,26,32,67,5,64,19,37,72,36,97,125,227,189,204,72,120,75,21,216,179,194,30,84,30,120,100,96,240,62,119,92,249,139,104,11,41,125,192,130,69,122,188,134,151,94,240,5,245,178,124,133,249,38,145,161,225,28,11,228,138,156,49,142,0,79,150,163,3,159,247,160,183,34,70,70,63,74,182,163,26,220,109,230,62,8,98,107,180,182,19,44,38,101,61,1,26,50,30,250,205,132,170,211,239,128,152,246,233,245,26,199,97,25,93,215,113,184,148,44,245,131,107,171,183,163,146,208,44,59,84,49,234,216,220,187,210,42,176,223,244,112,62,174,9,140,42,77,182,38,254,219,186,106,213,10,96,253,238,178,220,39,34,215,24,173,52,149,186,115,210,200,206,84,74,33,239,65,41,28,7,65,21,80,79,99,95,126,35,28,190,145,177,220,228,41,210,59,221,71,144,25,5,255,140,174,115,236,217,254,117,105,113,169,46,11,175,252,104,179,226,46,174,107,122,77,145,153,20,233,31,183,168,90,71,10,39,18,48,92,167,209,10,248,47,5,18,59,142,187,201,85,250,214,9,107,68,199,113,202,248,39,182,217,106,133,86,214,88,255,112,164,185,91,107,6,58,218,186,255,125,207,208,235,245,59,243,221,55,36,126,254,66,158,136,55,143,61,242,28,56,126,123,151,151,221,81,154,156,47,139,12,98,156,187,121,202,49,171,57,12,63,228,44,30,249,6,32,32,111,219,12,206,227,87,229,205,165,62,156,9,153,82,237,151,126,24,209,59,17,97,74,191,211,85,2,11,43,243,3,58,195,79,160,68,46,35,148,22,18,83,223,111,245,241,97,16,244,75,51,61,175,101,68,153,185,62,78,48,139,113,49,221,163,130,29,231,57,120,65,55,147,65,189,194,158,207,247,240,36,1,42,27,254,76,182,16,125,197,73,247,218,134,158,79,57,146,39,141,179,67,87,97,181,116,140,72,180,165,124,83,165,72,117,212,52,38,113,82,151,177,122,170,222,246,76,85,62,149,130,136,114,10,27,142,121,225,239,201,205,136,236,203,129,130,243,178,82,242,234,115,160,133,117,40,135,86,175,161,95,71,135,252,35,92,191,28,12,225,52,205,116,209,193,244,59,224,177,27,167,231,102,171,29,218,238,178,185,157,236,193,159,148,199,9,168,106,15,45,232,206,12,34,187,142,194,131,210,160,169,53,204,168,164,41,225,72,192,141,167,208,9,44,170,145,157,247,196,125,133,195,129,21,233,214,0,111,180,220,130,221,106,213,70,187,58,187,211,172,99,183,128,235,19,172,5,108,33,101,86,25,97,134,67,142,175,171,72,112,77,25,55,142,235,45,84,22,109,12,4,71,34,109,59,3,85,251,149,230,221,139,233,49,3,247,16,192,78,66,222,35,13,241,161,79,189,209,36,151,210,32,230,216,117,24,165,82,70,157,41,131,128,197,30,19,247,216,128,189,6,201,105,66,104,20,161,76,141,195,131,77,235,70,185,77,197,14,195,102,49,184,38,121,228,142,127,95,172,254,193,166,46,185,236,147,78,14,8,84,5,101,42,87,181,30,57,205,174,10,28,154,43,162,230,74,109,118,156,147,122,177,105,187,85,86,184,254,195,67,28,85,0,229,30,122,254,169,66,68,78,127,185,58,28,175,49,189,191,69,25,66,220,93,133,167,12,28,139,240,152,120,212,108,228,189,122,82,205,249,90,28,127,94,192,217,151,85,83,110,84,159,209,63,89,233,43,33,18,228,199,192,153,93,62,99,137,121,4,66,120,47,98,182,102,167,171,0,159,129,5,250,208,30,195,181,55,90,84,158,6,228,242,210,141,243,234,36,156,171,7,161,31,242,36,121,148,118,96,251,167,235,160,238,194,97,23,116,176,18,26,14,151,194,136,225,118,199,141,173,91,155,31,223,22,63,92,6,238,244,244,208,158,93,92,252,7,218,19,80,116,153,14,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateAppAlreadyExistsLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateAppAlreadyExistsLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("908fd631-0e9c-5abf-9037-6dbd9d6ee8c2"),
				Name = "AppAlreadyExists",
				CreatedInPackageId = new Guid("3c624d29-361c-47f2-ac8f-7824eb3cde6f"),
				CreatedInSchemaUId = new Guid("199b1a31-e071-4246-9057-1443d88896db"),
				ModifiedInSchemaUId = new Guid("199b1a31-e071-4246-9057-1443d88896db")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("199b1a31-e071-4246-9057-1443d88896db"));
		}

		#endregion

	}

	#endregion

}

