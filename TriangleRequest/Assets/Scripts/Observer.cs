using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Observer : MonoBehaviour
{
    public InputField SAValue, SBValue, SCValue, ABValue, ACValue;
    public Text SAAnswer, SBAnswer, SCAnswer, ABAnswer, ACAnswer;

    // Start is called before the first frame update
    void Start()
    {
        ResetValueAndAnswer();
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
    }

    public void ResetValueAndAnswer()
    {
        SAValue.gameObject.SetActive(true);
        SBValue.gameObject.SetActive(true);
        SCValue.gameObject.SetActive(true);
        ABValue.gameObject.SetActive(true);
        ACValue.gameObject.SetActive(true);
        SAValue.Select();
        SAValue.text = "";
        SBValue.Select();
        SBValue.text = "";
        SCValue.Select();
        SCValue.text = "";
        ABValue.Select();
        ABValue.text = "";
        ACValue.Select();
        ACValue.text = "";

        SAAnswer.text = "0";
        SBAnswer.text = "0";
        SCAnswer.text = "0";
        ABAnswer.text = "0";
        ACAnswer.text = "0";
        SAAnswer.gameObject.SetActive(false);
        SBAnswer.gameObject.SetActive(false);
        SCAnswer.gameObject.SetActive(false);
        ABAnswer.gameObject.SetActive(false);
        ACAnswer.gameObject.SetActive(false);
    }

    void ChangeSA()
    {
        SAValue.gameObject.SetActive(false);
        SAAnswer.gameObject.SetActive(true);
    }
    void ChangeSB()
    {
        SBValue.gameObject.SetActive(false);
        SBAnswer.gameObject.SetActive(true);
    }
    void ChangeSC()
    {
        SCValue.gameObject.SetActive(false);
        SCAnswer.gameObject.SetActive(true);
    }
    void ChangeAB()
    {
        ABValue.gameObject.SetActive(false);
        ABAnswer.gameObject.SetActive(true);
    }
    void ChangeAC()
    {
        ACValue.gameObject.SetActive(false);
        ACAnswer.gameObject.SetActive(true);
    }

    void CheckInput()
    {
        float sa, sb, sc, ab, ac;
        if (SAValue.text != "" && SBValue.text != "")
        {
            ChangeSC();
            ChangeAB();
            ChangeAC();

            sa = float.Parse(SAValue.text.ToString());
            sb = float.Parse(SBValue.text.ToString());
            sc = Mathf.Sqrt(sa*sa - sb*sb);
            ab = Mathf.Atan2(sc, sb) * Mathf.Rad2Deg;
            ac = Mathf.Atan2(sb, sc) * Mathf.Rad2Deg;

            SCAnswer.text = sc.ToString();
            ABAnswer.text = ab.ToString();
            ACAnswer.text = ac.ToString();
        }
        else if (SAValue.text != "" && SCValue.text != "")
        {
            ChangeSB();
            ChangeAB();
            ChangeAC();

            sa = float.Parse(SAValue.text.ToString());
            sc = float.Parse(SCValue.text.ToString());
            sb = Mathf.Sqrt(sa * sa - sc * sc);
            ab = Mathf.Atan2(sc, sb) * Mathf.Rad2Deg;
            ac = Mathf.Atan2(sb, sc) * Mathf.Rad2Deg;

            SBAnswer.text = sb.ToString();
            ABAnswer.text = ab.ToString();
            ACAnswer.text = ac.ToString();
        }
        else if (SAValue.text != "" && ABValue.text != "")
        {
            ChangeSB();
            ChangeSC();
            ChangeAC();

            sa = float.Parse(SAValue.text.ToString());
            ab = float.Parse(ABValue.text.ToString());
            ac = 90 - ab;
            sb = Mathf.Sin(ac * Mathf.Deg2Rad) * sa;
            sc = Mathf.Sin(ab * Mathf.Deg2Rad) * sa;

            SBAnswer.text = sb.ToString();
            SCAnswer.text = sc.ToString();
            ACAnswer.text = ac.ToString();
        }
        else if (SAValue.text != "" && ACValue.text != "")
        {
            ChangeSB();
            ChangeSC();
            ChangeAB();

            sa = float.Parse(SAValue.text.ToString());
            ac = float.Parse(ACValue.text.ToString());
            ab = 90 - ac;
            sb = Mathf.Sin(ac * Mathf.Deg2Rad) * sa;
            sc = Mathf.Sin(ab * Mathf.Deg2Rad) * sa;

            SBAnswer.text = sb.ToString();
            SCAnswer.text = sc.ToString();
            ABAnswer.text = ab.ToString();
        }
        else if (SBValue.text != "" && SCValue.text != "")
        {
            ChangeSA();
            ChangeAB();
            ChangeAC();

            sb = float.Parse(SBValue.text.ToString());
            sc = float.Parse(SCValue.text.ToString());
            sa = Mathf.Sqrt(sb * sb + sc * sc);
            ab = Mathf.Atan2(sc, sb) * Mathf.Rad2Deg;
            ac = Mathf.Atan2(sb, sc) * Mathf.Rad2Deg;

            SAAnswer.text = sa.ToString();
            ABAnswer.text = ab.ToString();
            ACAnswer.text = ac.ToString();

        }
        else if (SBValue.text != "" && ABValue.text != "")
        {
            ChangeSA();
            ChangeSC();
            ChangeAC();

            sb = float.Parse(SBValue.text.ToString());
            ab = float.Parse(ABValue.text.ToString());
            ac = 90 - ab;
            sa = sb / Mathf.Sin(ac * Mathf.Deg2Rad);
            sc = Mathf.Tan(ab * Mathf.Deg2Rad) * sb;

            SAAnswer.text = sa.ToString();
            SCAnswer.text = sc.ToString();
            ACAnswer.text = ac.ToString();
        }
        else if (SBValue.text != "" && ACValue.text != "")
        {
            ChangeSA();
            ChangeSC();
            ChangeAB();

            sb = float.Parse(SBValue.text.ToString());
            ac = float.Parse(ACValue.text.ToString());
            ab = 90 - ac;
            sa = sb / Mathf.Sin(ac * Mathf.Deg2Rad);
            sc = Mathf.Tan(ab * Mathf.Deg2Rad) * sb;

            SAAnswer.text = sa.ToString();
            SCAnswer.text = sc.ToString();
            ABAnswer.text = ab.ToString();
        }
        else if (SCValue.text != "" && ABValue.text != "")
        {
            ChangeSA();
            ChangeSB();
            ChangeAC();

            sc = float.Parse(SCValue.text.ToString());
            ab = float.Parse(ABValue.text.ToString());
            ac = 90 - ab;
            sa = sc / Mathf.Sin(ab * Mathf.Deg2Rad);
            sb = Mathf.Tan(ac * Mathf.Deg2Rad) * sc;

            SAAnswer.text = sa.ToString();
            SBAnswer.text = sb.ToString();
            ACAnswer.text = ac.ToString();
        }
        else if (SCValue.text != "" && ACValue.text != "")
        {
            ChangeSA();
            ChangeSB();
            ChangeAB();

            sc = float.Parse(SCValue.text.ToString());
            ac = float.Parse(ACValue.text.ToString());
            ab = 90 - ac;
            sa = sc / Mathf.Sin(ab * Mathf.Deg2Rad);
            sb = Mathf.Tan(ac * Mathf.Deg2Rad) * sc;

            SAAnswer.text = sa.ToString();
            SBAnswer.text = sb.ToString();
            ABAnswer.text = ab.ToString();
        }
    }
}
