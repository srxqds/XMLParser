/*----------------------------------------------------------------
// Copyright (C) 2015 ���ݣ�Lucky Game
//
// ģ������Xml ��������
// �����ߣ�D.S.Qiu
// �޸����б�
// �������ڣ�February 29 2016
// ģ��������
//----------------------------------------------------------------*/

#if WP_BUILD
using ArrayList = MarkerMetro.Unity.WinLegacy.Plugin.Collections.ArrayList;
#else
using System.Collections.Generic;
#endif


public class XMLNodeList : List<XMLNode>
{
    public XMLNode this[int index]
    {
        get
        {
            return base[index] as XMLNode;
        }
    }

	public XMLNode Pop()
	{
		XMLNode result = this[this.Count - 1] as XMLNode;
		this.RemoveAt(this.Count - 1);
		return result;
	}

	public void Push(XMLNode node)
	{
		this.Add(node);
	}

	public override string ToString()
	{
		string toText = string.Empty;
		foreach (XMLNode node in this) 
		{
			toText += node + "\n";
		}
		return toText;
	}
}
