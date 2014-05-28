<?php

/* ::Layout.html.twig */
class __TwigTemplate_b93f5a027526a9a250dcd601bbbbda16bc5b68c2ec0a3fcca90b37f862a94d85 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        $this->parent = false;

        $this->blocks = array(
            'title' => array($this, 'block_title'),
            'body' => array($this, 'block_body'),
        );
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        // line 1
        echo "<!DOCTYPE html>
<html>
   <head>
    <meta charset=utf-8\" />

    <title>";
        // line 6
        $this->displayBlock('title', $context, $blocks);
        echo "</title>

    ";
        // line 8
        if (isset($context['assetic']['debug']) && $context['assetic']['debug']) {
            // asset "a47821c_0"
            $context["asset_url"] = isset($context['assetic']['use_controller']) && $context['assetic']['use_controller'] ? $this->env->getExtension('routing')->getPath("_assetic_a47821c_0") : $this->env->getExtension('assets')->getAssetUrl("_controller/css/a47821c_bootstrap_1.css");
            // line 9
            echo "      <link rel=\"stylesheet\" href=\"";
            echo twig_escape_filter($this->env, (isset($context["asset_url"]) ? $context["asset_url"] : $this->getContext($context, "asset_url")), "html", null, true);
            echo "\" type=\"text/css\" media=\"all\"/>
    ";
        } else {
            // asset "a47821c"
            $context["asset_url"] = isset($context['assetic']['use_controller']) && $context['assetic']['use_controller'] ? $this->env->getExtension('routing')->getPath("_assetic_a47821c") : $this->env->getExtension('assets')->getAssetUrl("_controller/css/a47821c.css");
            echo "      <link rel=\"stylesheet\" href=\"";
            echo twig_escape_filter($this->env, (isset($context["asset_url"]) ? $context["asset_url"] : $this->getContext($context, "asset_url")), "html", null, true);
            echo "\" type=\"text/css\" media=\"all\"/>
    ";
        }
        unset($context["asset_url"]);
        // line 11
        echo "  </head>

  <body>
    <div class=\"container\">
     <div id=\"header\" class=\"hero-unit\">
        <h1>Application Rent Car</h1>
     </div>
        <div class=\"row\">
            <div id=\"menu\" class=\"span3\">
                <h4>Espace accueil</h4>
                <ul> 
                    <li><a href=\"";
        // line 22
        echo $this->env->getExtension('routing')->getPath("sdzRentCarAppli_accueil");
        echo "\">Accueil</a></li>
                </ul>
                <h4>Espace location</h4>
                <ul>
                    <li><a href=\"";
        // line 26
        echo $this->env->getExtension('routing')->getPath("sdzRentCarAppli_voir");
        echo "\">Liste des véhicules disponibles</a></li>
                    <li><a href=\"";
        // line 27
        echo $this->env->getExtension('routing')->getPath("sdzRentCarAppli_louer");
        echo "\">Louer un véhicule</a></li>
                    <li><a href=\"";
        // line 28
        echo $this->env->getExtension('routing')->getPath("sdzRentCarAppli_voirLouer");
        echo "\">Liste des véhicules louées</a></li>
                </ul>
        </div>
        <div id=\"content\" class=\"span9\">
          ";
        // line 32
        $this->displayBlock('body', $context, $blocks);
        // line 34
        echo "        </div>
      </div>

      <hr>

      <footer>
          <center><p>Baudouin © 2013 and beyond.</p></center>
      </footer>
    </div>
  </body>
</html>";
    }

    // line 6
    public function block_title($context, array $blocks = array())
    {
        echo "Application Rent Car";
    }

    // line 32
    public function block_body($context, array $blocks = array())
    {
        // line 33
        echo "          ";
    }

    public function getTemplateName()
    {
        return "::Layout.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  111 => 33,  108 => 32,  102 => 6,  88 => 34,  86 => 32,  79 => 28,  75 => 27,  71 => 26,  64 => 22,  51 => 11,  37 => 9,  33 => 8,  28 => 6,  21 => 1,);
    }
}
