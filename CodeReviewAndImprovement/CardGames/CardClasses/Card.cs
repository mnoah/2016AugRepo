﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClasses
{
    public class Card
    {
        private string m_suitName;
        private int m_pointValue;
        private string m_faceName;
        public Card()
        {
            m_faceName = "";
            m_suitName = "";
            m_pointValue = 0;
        }
        public Card(string suitName, int pointValue)
        {
            m_suitName = suitName;
            m_pointValue = pointValue;
        }
        public string SuitName
        {
            get { return m_suitName; }
            set { m_suitName = value; }
        }
        public int PointValue
        {
            get { return m_pointValue; }
            set { m_pointValue = value; }
        }

    }
}
