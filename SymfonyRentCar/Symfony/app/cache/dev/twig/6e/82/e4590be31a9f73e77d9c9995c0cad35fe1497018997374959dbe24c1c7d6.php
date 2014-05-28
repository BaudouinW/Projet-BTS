<?php

/* SdzRentCarBundle:RentCarViews:formulaire.html.twig */
class __TwigTemplate_6e82e4590be31a9f73e77d9c9995c0cad35fe1497018997374959dbe24c1c7d6 extends Twig_Template
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
        <input type=\"submit\" class=\"btn btn-primary\"/>
    </form>
</div>
";
    }

    public function getTemplateName()
    {
        return "SdzRentCarBundle:RentCarViews:formulaire.html.twig";
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
