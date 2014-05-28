<?php

/* SdzRentCarBundle:RentCarViews:formulaireLouer.html.twig */
class __TwigTemplate_24f8cb7afce70e27906c8af1c306008469c213092e64e29f2cf2f99e3611455d extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        $this->parent = false;

        $this->blocks = array(
        );
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        // line 4
        echo "
";
        // line 6
        echo "<div class=\"well\">
    <form method=\"post\" ";
        // line 7
        echo $this->env->getExtension('form')->renderer->searchAndRenderBlock((isset($context["form"]) ? $context["form"] : $this->getContext($context, "form")), 'enctype');
        echo ">
        ";
        // line 8
        echo $this->env->getExtension('form')->renderer->searchAndRenderBlock((isset($context["form"]) ? $context["form"] : $this->getContext($context, "form")), 'widget');
        echo "<br/>
        <input type=\"submit\" class=\"btn btn-primary\" value=\"Envoyer la demande\"/>
    </form>
</div>
";
    }

    public function getTemplateName()
    {
        return "SdzRentCarBundle:RentCarViews:formulaireLouer.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  29 => 8,  25 => 7,  22 => 6,  19 => 4,);
    }
}
