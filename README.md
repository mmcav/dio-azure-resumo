# DIO Microsoft Azure Essentials - Resumão do Curso

## O que é o Azure

O Azure é uma plataforma de computação em nuvem da Microsoft que oferece uma variedade de serviços, incluindo computação, armazenamento, análise e redes. Ele permite que empresas e desenvolvedores criem, implantem e gerenciem aplicativos e serviços por meio de datacenters globais. A flexibilidade e a escalabilidade do Azure fazem dele uma escolha popular para soluções em nuvem, atendendo tanto pequenas empresas quanto grandes corporações.

## Criando uma Conta no Azure

Para começar a usar o Azure, é necessário criar uma conta. O processo é simples e envolve as seguintes etapas:

1. **Visitar o site do Azure**: Acesse a página oficial do Azure.
2. **Selecionar "Começar gratuitamente"**: Isso oferece um período de teste e créditos iniciais.
3. **Criar um perfil**: Insira informações pessoais, como nome, e-mail e detalhes de pagamento (opcional durante o teste).
4. **Verificar a conta**: Siga as instruções para validar seu e-mail e, se necessário, seu número de telefone.
5. **Explorar o portal**: Após a criação da conta, você pode acessar o portal do Azure para gerenciar serviços.

## O Portal do Azure

O portal do Azure é uma interface baseada na web que permite aos usuários gerenciar recursos e serviços na plataforma. Através dele, é possível:

- **Criar e gerenciar recursos**: Criação de máquinas virtuais, bancos de dados, aplicativos e muito mais.
- **Monitorar serviços**: Visualizar desempenho, uso e métricas dos recursos implantados.
- **Configurar segurança e governança**: Gerenciar permissões e políticas de acesso.
- **Acessar documentação e suporte**: Encontrar guias, tutoriais e recursos de ajuda.

O portal é projetado para ser intuitivo, permitindo que usuários de todos os níveis de experiência naveguem e utilizem suas funcionalidades de forma eficiente.

## Benefícios da Nuvem

A computação em nuvem oferece diversos benefícios que ajudam empresas a otimizar seus recursos e operações. Alguns dos principais benefícios incluem:

- **Escalabilidade**: Permite ajustar rapidamente a capacidade dos recursos de acordo com a demanda, garantindo que os serviços possam crescer ou diminuir conforme necessário.
- **Elasticidade**: Os recursos podem ser provisionados e liberados automaticamente, permitindo que as empresas paguem apenas pelo que realmente utilizam.
- **Confiabilidade**: A infraestrutura de nuvem é projetada para garantir alta disponibilidade e continuidade de negócios, minimizando o risco de falhas.
- **Previsibilidade**: Com ferramentas de monitoramento e análise, as empresas podem prever tendências de uso e planejar melhor seus recursos.
- **Segurança**: Fornece diversas camadas de segurança, incluindo criptografia, autenticação e controle de acesso, para proteger dados e aplicações.
- **Governança**: Permite que as organizações implementem políticas e controles para garantir a conformidade e a gestão eficaz dos recursos.
- **Gerenciabilidade**: Facilita o gerenciamento centralizado dos recursos, simplificando tarefas de administração e manutenção.

## Service Level Agreement

Um Service Level Agreement (SLA) é um contrato que define os níveis de serviço esperados entre um provedor de serviços em nuvem e um cliente. Ele especifica as métricas de desempenho, como disponibilidade e tempo de resposta. No Azure, os SLAs geralmente oferecem percentuais de disponibilidade que variam de 99,9% a 99,99999%, dependendo do serviço. Isso garante que os clientes tenham uma expectativa clara sobre a confiabilidade dos serviços que estão utilizando.

## Como Criar uma Máquina Virtual

Criar uma máquina virtual no Azure é um processo simples e envolve algumas etapas principais. As opções disponíveis incluem:

1. **Escolher o sistema operacional**: Você pode optar por diversas distribuições do Windows e Linux.
2. **Selecionar a configuração da VM**: Escolha entre diferentes tamanhos e tipos de máquina, dependendo da carga de trabalho (ex: General Purpose, Compute Optimized).
3. **Configurar armazenamento**: Escolha entre discos gerenciados ou não gerenciados, além de definir o tipo de armazenamento (SSD, HDD).
4. **Definir rede**: Configure as definições de rede, incluindo segurança, grupos de segurança e sub-redes.
5. **Configurações adicionais**: Defina opções como autenticação, backup e monitoramento.

Após a configuração, você pode iniciar a máquina virtual e gerenciá-la através do portal do Azure ou por meio de scripts automáticos.

## Tipos de Serviço de Nuvem na Azure

A Azure oferece três principais modelos de serviços em nuvem:

- **IaaS (Infrastructure as a Service)**: Proporciona infraestrutura básica, como máquinas virtuais e redes. Exemplos incluem Azure Virtual Machines e Azure Virtual Networks.
- **PaaS (Platform as a Service)**: Fornece uma plataforma completa para desenvolvimento, teste e implementação de aplicações, sem se preocupar com a infraestrutura subjacente. Exemplos incluem Azure App Service e Azure Functions.
- **SaaS (Software as a Service)**: Oferece aplicativos prontos para uso, acessíveis via internet, como Microsoft 365 e Dynamics 365.

Esses modelos permitem que as empresas escolham o nível de controle e responsabilidade que desejam ter sobre seus recursos em nuvem.

## Modelo de Responsabilidade Compartilhada

O modelo de responsabilidade compartilhada descreve as responsabilidades de segurança e conformidade entre o provedor de serviços em nuvem (Azure) e o cliente. No Azure, o provedor é responsável pela segurança da infraestrutura que compõe os serviços em nuvem, incluindo hardware, software, redes e instalações. Por outro lado, os clientes são responsáveis pela segurança de suas aplicações e dados, incluindo o gerenciamento de identidades, criptografia e configurações de rede. Este modelo ajuda as empresas a entenderem claramente onde suas responsabilidades começam e terminam.

## Como Criar um Banco de Dados SQL

Criar um banco de dados SQL no Azure é um processo direto que envolve algumas etapas:

1. **Acessar o Portal do Azure**: Entre na sua conta do Azure e acesse o portal.
2. **Selecionar "Criar um recurso"**: Clique na opção para criar um novo recurso.
3. **Escolher "Banco de Dados SQL"**: Na seção de bancos de dados, selecione a opção para Banco de Dados SQL.
4. **Configurar os detalhes do banco de dados**:
   - **Nome**: Defina um nome exclusivo para o banco de dados.
   - **Servidor**: Crie um novo servidor ou escolha um existente. Isso inclui definir a localização e a configuração de autenticação.
   - **Recursos**: Escolha o nível de desempenho e as opções de escalabilidade, como DTUs ou vCores.
5. **Configurações adicionais**: Configure opções como backup, segurança e firewall.
6. **Revisar e criar**: Revise as configurações e clique em "Criar" para finalizar a implantação.

Após a criação, você pode gerenciar o banco de dados através do portal do Azure ou usar ferramentas como o SQL Server Management Studio.

## Regiões do Azure e Zonas de Disponibilidade

O Azure está distribuído em diversas regiões ao redor do mundo, cada uma consistindo em um ou mais datacenters. As **Zonas de Disponibilidade** são um conjunto de datacenters em uma região que operam de forma independente para garantir alta disponibilidade e resiliência. Isso permite que os serviços permaneçam operacionais mesmo em caso de falhas em uma parte da infraestrutura.

## Pares de Regiões

Os **pares de regiões** no Azure são uma configuração que conecta duas regiões geográficas próximas. Essa configuração é utilizada para garantir a recuperação de desastres e alta disponibilidade, permitindo que os dados sejam replicados entre regiões. Por exemplo, se uma região falhar, a outra pode assumir as operações, minimizando a interrupção dos serviços.

## Regiões Soberanas

As **regiões soberanas** são datacenters do Azure que atendem a requisitos específicos de conformidade e soberania de dados de determinados países. Essas regiões garantem que os dados permaneçam dentro das fronteiras nacionais e cumpram regulamentos locais. Exemplos incluem a Microsoft Cloud Alemanha e a Microsoft Cloud para o Governo dos EUA.

## Grupos de Recursos

Os **grupos de recursos** são containers lógicos que permitem agrupar e gerenciar recursos do Azure. Eles facilitam a organização de recursos, como máquinas virtuais, bancos de dados e redes, e permitem a aplicação de políticas, controle de acesso e gerenciamento de custos de forma centralizada.

## Assinaturas do Azure

Uma **assinatura do Azure** é uma forma de acessar os serviços do Azure e gerenciar recursos. Cada assinatura possui limites de uso e pode incluir cobranças associadas. As organizações podem ter várias assinaturas para separar ambientes, como desenvolvimento, teste e produção, ou para diferentes departamentos ou projetos.

## Grupos de Gerenciamento

Os **grupos de gerenciamento** são uma camada hierárquica que permite organizar e gerenciar várias assinaturas do Azure de forma eficiente. Eles ajudam a aplicar políticas e controles de segurança em um conjunto de assinaturas, facilitando a governança e a conformidade em grandes organizações. Isso permite uma visão consolidada e um controle mais eficiente sobre os recursos do Azure.

## Serviços de Computação do Azure

O Azure oferece uma variedade de serviços de computação que permitem executar aplicações e gerenciar recursos de forma eficiente:

- **Máquinas Virtuais**: Proporcionam a capacidade de executar sistemas operacionais e aplicativos na nuvem, permitindo que os usuários escolham o tamanho e as especificações da VM de acordo com suas necessidades.
- **Conjuntos de Disponibilidade de Máquinas Virtuais**: Garantem que as VMs sejam implantadas em diferentes datacenters dentro da mesma região, aumentando a resiliência e a disponibilidade de aplicativos.
- **Área de Trabalho Virtual do Azure**: Permite que os usuários acessem desktops e aplicativos de qualquer lugar, oferecendo uma experiência semelhante a um desktop físico na nuvem.
- **Containers**: Facilita a criação, implantação e gerenciamento de aplicações em containers, permitindo uma abordagem mais ágil para o desenvolvimento e a operação.
- **Serviços de Kubernetes do Azure (AKS)**: Oferece um serviço gerenciado para orquestrar containers usando Kubernetes, simplificando o gerenciamento de clusters e a implantação de aplicações.
- **Azure Functions**: Um serviço de computação sem servidor que permite executar código em resposta a eventos, eliminando a necessidade de gerenciar servidores e infraestrutura.
- **Serviços de Aplicativo do Azure**: Proporciona uma plataforma para criar e hospedar aplicativos web e APIs, oferecendo recursos integrados como escalabilidade e gerenciamento.

## Serviços de Rede do Azure

O Azure disponibiliza diversos serviços de rede que ajudam a conectar e gerenciar recursos de forma segura e eficiente:

- **VNet (Virtual Network)**: Cria redes privadas isoladas na nuvem, permitindo que recursos se comuniquem de forma segura e eficiente.
- **Gateway de VPN**: Facilita a conexão segura entre a rede local e a VNet no Azure através de uma conexão VPN, garantindo que os dados sejam transmitidos de forma segura.
- **ExpressRoute**: Proporciona uma conexão privada e dedicada entre a infraestrutura local e o Azure, melhorando a segurança e a latência em comparação com conexões pela internet pública.
- **DNS do Azure**: Um serviço de gerenciamento de nomes de domínio que fornece resolução de nomes para serviços e recursos dentro do Azure, além de suporte para domínios públicos.

## Armazenamento no Azure

O Azure oferece diversas soluções de armazenamento que atendem a diferentes necessidades de dados e desempenho:

- **Contas de Armazenamento**: Servem como containers para diferentes tipos de serviços de armazenamento, permitindo gerenciar e acessar dados de maneira eficiente.
- **Redundância de Armazenamento**: Oferece opções para garantir a durabilidade e a disponibilidade dos dados, incluindo armazenamento localmente redundante (LRS) e geograficamente redundante (GRS).
- **Blob do Azure**: Um serviço de armazenamento para grandes quantidades de dados não estruturados, como imagens, vídeos e arquivos de áudio.
- **Disco do Azure**: Fornece armazenamento persistente para máquinas virtuais, oferecendo discos gerenciados e não gerenciados com diferentes níveis de desempenho.
- **Fila do Azure**: Um serviço de mensageria que permite a comunicação entre componentes de aplicativos, garantindo que mensagens sejam armazenadas e processadas de forma confiável.
- **Arquivos do Azure**: Oferece um serviço de compartilhamento de arquivos na nuvem que pode ser acessado via SMB, permitindo que aplicativos legados sejam migrados facilmente para a nuvem.
- **Tabelas do Azure**: Um serviço de armazenamento NoSQL que permite armazenar e consultar grandes quantidades de dados estruturados.
- **Pontos de Extremidade Públicos do Azure**: Permitem acessar serviços de armazenamento através da internet, facilitando a integração com aplicações externas.
- **Camadas de Acesso de Armazenamento do Azure**: Proporcionam opções de gerenciamento de custo, permitindo armazenar dados em diferentes camadas (hot, cool, archive) dependendo da frequência de acesso.

## Migração de Dados para o Azure

A migração de dados para o Azure pode ser realizada através de várias ferramentas:

- **Azure Data Box**: Um dispositivo físico que permite transferir grandes volumes de dados para o Azure de forma segura e eficiente, ideal para cargas de trabalho que não podem ser transferidas pela internet.
- **AzCopy**: Uma ferramenta de linha de comando que permite copiar dados entre o armazenamento local e os serviços de armazenamento do Azure de maneira rápida e eficiente.

## Gerenciamento de Dados do Azure

O gerenciamento de dados no Azure é facilitado por várias ferramentas e serviços:

- **Gerenciador de Armazenamento do Azure**: Um painel centralizado que permite monitorar e gerenciar contas de armazenamento, configurações e acesso a dados de forma intuitiva.
- **Sincronização de Arquivos do Azure**: Permite que arquivos em um servidor local sejam sincronizados com o armazenamento do Azure, garantindo que os dados estejam sempre atualizados e disponíveis em múltiplas localizações.

## Identidade, Acesso e Segurança

O Azure oferece uma ampla gama de ferramentas e serviços para gerenciar identidades, acesso e segurança, garantindo que apenas usuários autorizados possam acessar recursos e dados críticos.

## Autenticação e Autorização

A autenticação e autorização são essenciais para a segurança. O Azure suporta várias formas de autenticação, incluindo:

- **MFA (Autenticação Multifatorial)**: Adiciona uma camada extra de segurança, exigindo que os usuários forneçam duas ou mais formas de verificação antes de acessar um recurso.

## Microsoft Entra ID e Microsoft Entra Domain Services

- **Microsoft Entra ID**: É um serviço de gerenciamento de identidade e acesso que permite gerenciar usuários e grupos, além de fornecer autenticação para aplicações.
- **Microsoft Entra Domain Services**: Proporciona serviços de domínio gerenciados na nuvem, permitindo que aplicativos e serviços utilizem autenticação de diretório sem a necessidade de implantar controladores de domínio.

## Azure Active Directory

O **Azure Active Directory (Azure AD)** é um serviço de gerenciamento de identidade e acesso baseado em nuvem. Ele permite que os usuários acessem aplicativos e recursos de forma segura, integrando autenticação, autorização e gerenciamento de usuários em uma única plataforma.

## Acesso Condicional do Microsoft Entra

O **Acesso Condicional** permite implementar políticas de segurança com base em condições específicas, como localização do usuário ou dispositivo. Isso ajuda a garantir que apenas os usuários com condições seguras possam acessar determinados recursos.

## Controle de Acesso Baseado em Função

O **Controle de Acesso Baseado em Função (RBAC)** permite gerenciar quem pode acessar recursos no Azure, definindo permissões com base nas funções atribuídas aos usuários. Isso garante que os usuários tenham apenas os níveis de acesso necessários para suas funções.

## Confiança Zero e Defesa em Profundidade

A abordagem de **Confiança Zero** implica que nenhuma entidade, interna ou externa, deve ser automaticamente confiável. Todas as tentativas de acesso devem ser verificadas. A **Defesa em Profundidade** utiliza múltiplas camadas de segurança para proteger os dados, garantindo que se uma camada for comprometida, outras ainda estão em vigor para proteger os recursos.

## Microsoft Defender para a Nuvem

O **Microsoft Defender para a Nuvem** é uma solução de segurança integrada que fornece proteção contra ameaças, monitoramento de segurança e avaliações de conformidade. Ele ajuda a proteger a infraestrutura e os dados no Azure, além de fornecer recomendações de segurança personalizadas.

## Azure Marketplace

O Azure Marketplace é uma plataforma que permite aos usuários encontrar, testar e adquirir aplicações e serviços baseados em nuvem. Ele oferece uma ampla gama de soluções de diferentes fornecedores, que vão desde software como serviço (SaaS) até infraestrutura como serviço (IaaS). Os usuários podem acessar soluções que atendem a diversas necessidades empresariais, facilitando a integração e a implementação de tecnologias no ambiente Azure.

## Calculadora de Preços

A Calculadora de Preços do Azure é uma ferramenta essencial que permite aos usuários estimar os custos dos serviços da Microsoft Azure antes de se comprometerem com uma assinatura. A calculadora permite que os usuários selecionem serviços específicos, ajustem configurações e vejam uma estimativa detalhada dos custos mensais, ajudando na tomada de decisões financeiras mais informadas.

## Calculadora de Custo Total de Propriedade

A Calculadora de Custo Total de Propriedade (TCO) do Azure oferece uma análise abrangente dos custos envolvidos na operação de um ambiente de TI na nuvem em comparação com soluções locais. Essa ferramenta considera diversos fatores, como custos de hardware, software, manutenção e operação, proporcionando uma visão clara dos benefícios econômicos de migrar para o Azure.

## Gerenciamento de Custos do Azure

O Gerenciamento de Custos do Azure é um conjunto de ferramentas e práticas que ajuda as organizações a monitorar, analisar e otimizar seus gastos na nuvem. Ele inclui recursos como relatórios de uso, alertas de gastos e recomendações de economia. Essa abordagem proativa permite que as empresas mantenham os custos sob controle e maximizem o valor de seus investimentos em nuvem.

## Tags e Cobranças

As tags são um recurso valioso no Azure que permite categorizar e organizar recursos para melhor gerenciamento e controle de custos. Ao atribuir tags a diferentes recursos, as empresas podem rastrear despesas de maneira mais eficaz e gerar relatórios detalhados sobre o uso e os custos por departamento, projeto ou equipe. Isso facilita a análise de despesas e ajuda a identificar oportunidades de economia.

## Governança e Conformidade

A governança e conformidade na nuvem Azure são fundamentais para garantir que as organizações operem dentro de diretrizes regulatórias e políticas internas. A Azure fornece ferramentas e práticas que ajudam a implementar controles, monitorar a conformidade e gerenciar riscos, assegurando que os dados e recursos estejam protegidos e em conformidade com as normas legais e de segurança.

## Azure Policy

O Azure Policy é uma ferramenta que permite às organizações criar, atribuir e gerenciar políticas que asseguram a conformidade dos recursos no Azure. Com ele, os administradores podem definir regras e efeitos que se aplicam a recursos específicos, garantindo que esses recursos atendam aos padrões corporativos e regulatórios. Isso ajuda a prevenir a criação de recursos não conformes e facilita a auditoria.

## Microsoft Purview

O Microsoft Purview é uma solução abrangente para governança de dados que permite às organizações descobrir, classificar e proteger seus dados em ambientes híbridos e de múltiplas nuvens. Ele oferece funcionalidades para mapear dados, entender suas origens e garantir que estejam em conformidade com as políticas de privacidade e regulamentações. Isso facilita a gestão e proteção dos dados sensíveis da organização.

## Portal de Confiança do Serviço

O Portal de Confiança do Serviço é uma plataforma que fornece informações detalhadas sobre a conformidade, segurança e privacidade dos serviços da Azure. Ele inclui relatórios de auditoria, certificações e detalhes sobre as práticas de segurança da Microsoft, permitindo que as organizações avaliem a confiabilidade dos serviços utilizados. Esse portal é uma ferramenta valiosa para empresas que buscam garantir que seus dados estejam protegidos e em conformidade.

## Azure Resource Manager

O Azure Resource Manager (ARM) é a plataforma de gerenciamento de recursos do Azure que permite criar, atualizar e excluir recursos em uma conta do Azure. Com o ARM, os usuários podem implantar e gerenciar recursos de forma consistente e em grupos, facilitando a organização e a governança. Ele também oferece suporte para modelos de implantação, permitindo automação e controle de versão.

## Azure Arc

O Azure Arc é uma solução que estende os serviços e a gestão do Azure a ambientes híbridos e multicloud. Ele permite que os usuários gerenciem servidores, Kubernetes e bancos de dados fora do Azure, utilizando a mesma interface e ferramentas. Com o Azure Arc, as organizações podem unificar a governança e a segurança, além de aplicar políticas de conformidade em recursos que estão em qualquer lugar.

## Azure Bicep

O Azure Bicep é uma linguagem de modelagem de infraestrutura como código que simplifica a criação de templates para o Azure Resource Manager. Ele oferece uma sintaxe mais limpa e legível em comparação com JSON, tornando mais fácil a definição e o gerenciamento de recursos no Azure. Com o Bicep, os desenvolvedores podem acelerar o desenvolvimento e a manutenção de suas infraestruturas na nuvem.

## Assistente do Azure

O Assistente do Azure é uma ferramenta que ajuda os usuários a gerenciar e otimizar seus serviços na nuvem. Ele fornece recomendações personalizadas, orientações sobre melhores práticas e suporte em tempo real para resolver problemas comuns. O Assistente do Azure é projetado para simplificar a experiência do usuário, tornando mais fácil a navegação e a utilização dos recursos disponíveis.

## Integridade do Serviço do Azure

A Integridade do Serviço do Azure é uma plataforma que fornece informações sobre o status dos serviços do Azure em tempo real. Os usuários podem acessar relatórios de incidentes, manutenção programada e atualizações sobre o desempenho dos serviços. Isso ajuda as organizações a entender melhor a disponibilidade dos serviços e a planejar suas operações de forma eficaz, minimizando interrupções.

## Azure Monitor

O Azure Monitor é uma solução abrangente de monitoramento que fornece insights sobre o desempenho e a integridade dos aplicativos e serviços no Azure. Ele coleta e analisa dados de logs, métricas e diagnósticos, permitindo que os usuários detectem e resolvam problemas rapidamente. Com recursos de alertas e painéis personalizáveis, o Azure Monitor ajuda as organizações a otimizar suas operações na nuvem e a garantir a continuidade dos serviços.
