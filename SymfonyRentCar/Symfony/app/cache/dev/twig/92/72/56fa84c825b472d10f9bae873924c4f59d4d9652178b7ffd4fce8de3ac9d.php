<?php

/* SdzRentCarBundle::layout.html.twig */
class __TwigTemplate_927256fa84c825b472d10f9bae873924c4f59d4d9652178b7ffd4fce8de3ac9d extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        $this->parent = $this->env->loadTemplate("::Layout.html.twig");

        $this->blocks = array(
            'title' => array($this, 'block_title'),
            'body' => array($this, 'block_body'),
            'RentCarAppli_body' => array($this, 'block_RentCarAppli_body'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "::Layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $this->parent->display($context, array_merge($this->blocks, $blocks));
    }

    // line 3
    public function block_title($context, array $blocks = array())
    {
        // line 4
        echo "   ";
        $this->displayParentBlock("title", $context, $blocks);
        echo "
";
    }

    // line 6
    public function block_body($context, array $blocks = array())
    {
        // line 7
        echo "  ";
        // line 8
        echo " 
  ";
        // line 10
        echo "  ";
        $this->displayBlock('RentCarAppli_body', $context, $blocks);
    }

    public function block_RentCarAppli_body($context, array $blocks = array())
    {
        // line 11
        echo "  ";
    }

    public function getTemplateName()
    {
        return "SdzRentCarBundle::layout.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  55 => 11,  48 => 10,  45 => 8,  43 => 7,  40 => 6,  33 => 4,  30 => 3,);
    }
}
